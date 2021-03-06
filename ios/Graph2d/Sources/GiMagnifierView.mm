// GiMagnifierView.mm
// Copyright (c) 2012, Zhang Yungui <rhcad@hotmail.com>
// License: LGPL, https://github.com/rhcad/touchvg

#import "GiGraphView.h"
#include <iosgraph.h>
#include <mgshapedoc.h>
#include <mgshape.h>

@interface GiMagnifierView ()

- (BOOL)draw:(GiGraphics*)gs;                           //!< 显示全部图形内部调用
- (BOOL)dynDraw:(GiGraphics*)gs;                        //!< 动态显示时内部调用
- (BOOL)isActiveView;                                   //!< 返回本视图是否为当前交互视图
- (void)updateTransform;

@end

@implementation GiMagnifierView

@synthesize pointW = _pointW;
@synthesize scale = _scale;
@synthesize lockRedraw = _lockRedraw;

- (id)initWithFrame:(CGRect)frame graphView:(id<GiView>)gview
{
    self = [super initWithFrame:frame];
    if (self) {
        _graph = new GiGraphIos();
        _graph->xf.setViewScaleRange(1e-5, 50);
        _graph->gs.setMaxPenWidth(4);
        _gview = gview;
        _drawingDelegate = Nil;
        _shapeAdded = NULL;
        _cachedDraw = YES;
        _scale = 3;
        _lockRedraw = NO;
        _zooming = NO;
        
        self.contentMode = UIViewContentModeRedraw;
        self.multipleTouchEnabled = YES;
    }
    return self;
}

- (void)dealloc
{
    if (_graph) {
        delete _graph;
        _graph = NULL;
    }
    [super dealloc];
}

- (BOOL)isActiveView
{
    return ([_drawingDelegate respondsToSelector:@selector(activeView)]
            && self == [_drawingDelegate performSelector:@selector(activeView)]);
}

- (void)setPointW:(CGPoint)ptw {
    _pointW = ptw;
    if (!_lockRedraw || [self isActiveView]) {
        Point2d ptd = Point2d(ptw.x, ptw.y) * _graph->xf.worldToDisplay();
        BOOL inside = CGRectContainsPoint(CGRectInset(self.bounds, 10, 10), 
                                          CGPointMake(ptd.x, ptd.y));
        if (!inside) {
            _graph->xf.zoom(Point2d(ptw.x, ptw.y), _graph->xf.getViewScale());
        }
        _cachedDraw = YES;
        [self setNeedsDisplay];
    }
}

- (void)setPointWandRedraw:(CGPoint)ptw :(BOOL)fromClick
{
    _zoomCenter = ptw;
    if (fromClick) {
        float off = (self.bounds.size.width - 10) / _graph->xf.getWorldToDisplayX();
        ptw.x += off / 2.f;
    }
    _pointW = ptw;
    _graph->xf.zoom(Point2d(ptw.x, ptw.y), _graph->xf.getViewScale());
    _cachedDraw = YES;
    [self setNeedsDisplay];
}

- (void)zoomPan:(CGPoint)translation
{
    if (_graph->xf.zoomPan(translation.x, translation.y)) {
        BOOL savept = CGPointEqualToPoint(_zoomCenter, _pointW);
        _pointW = CGPointMake(_graph->xf.getCenterW().x, _graph->xf.getCenterW().y);
        _zoomCenter = _pointW;
        if (!savept) {
            float off = (self.bounds.size.width - 10) / _graph->xf.getWorldToDisplayX();
            _zoomCenter.x -= off / 2.f;
        }
        _cachedDraw = YES;
        [self setNeedsDisplay];
        [[_gview ownerView] setNeedsDisplay];
    }
}

- (MgShapeDoc*)doc {
    return [_gview doc];
}

- (GiTransform*)xform {
    return &_graph->xf;
}

- (GiGraphics*)graph {
    return &_graph->gs;
}

- (UIView*)ownerView {
    return self;
}

- (void)setDoc:(MgShapeDoc*)data {
}

- (void)setAnimating:(BOOL)animated {
    if (animated)
        _zooming |= 0x2;
    else
        _zooming &= ~0x2;
}

- (void)setDrawingDelegate:(id)d {
    _drawingDelegate = (UIResponder*)d;
}

- (void)regen {
    _graph->gs.clearCachedBitmap();
    _cachedDraw = YES;
    [self setNeedsDisplay];
}

- (void)redraw:(bool)fast {
    _cachedDraw = !fast;
    [self setNeedsDisplay];
    
    if (!_lockRedraw && [self isActiveView]) {
        [_gview redraw:fast];
    }
}

- (BOOL)isZooming {
    return _zooming || [_gview isZooming];
}

- (void)updateTransform
{
    GiTransform& xf = _graph->xf;
    
    xf.setWndSize(CGRectGetWidth(self.bounds), CGRectGetHeight(self.bounds));
    if ([_gview doc]) {
        MgShapesLock locker([_gview doc], MgShapesLock::ReadOnly);
        if (locker.locked()) {
            _graph->xf.setModelTransform([_gview doc]->modelTransform());
        }
    }
    
    if (_scale < 1 && !self.hidden && ![_gview isZooming]) {    // 缩略视图，动态放缩时不regen
        CGSize gsize = [_gview ownerView].bounds.size;
        Box2d rcw(Box2d(0.f, 0.f, gsize.width, gsize.height) * [_gview xform]->displayToWorld());
        Box2d rcd(rcw * xf.worldToDisplay());       // 实际图形视图在本视图中的位置
        
        if (rcd.width() < self.bounds.size.width
            && rcd.height() < self.bounds.size.height) {
            CGRect rcd2 = CGRectMake(rcd.xmin, rcd.ymin, rcd.width(), rcd.height());
            if (!CGRectContainsRect(self.bounds, rcd2)) {   // 出界则平移显示
                xf.zoomPan(CGRectGetMidX(self.bounds) - rcd.center().x,
                           CGRectGetMidY(self.bounds) - rcd.center().y);
            }
        }
    }
    if (![_gview isZooming]) {                      // 同步显示比例，动态放缩时除外
        xf.zoom(xf.getCenterW(), [_gview xform]->getViewScale() * _scale);
    }
}

- (void)drawRect:(CGRect)rect
{
    [self updateTransform];
    
    CGContextRef context = UIGraphicsGetCurrentContext();
    GiCanvasIos &cv = *_graph->canvas;
    GiGraphics &gs = _graph->gs;
    bool nextDraw = false;

    if (!self.hidden && !self.superview.hidden &&
        cv.beginPaint(context, [self isZooming]))   // 在当前画布上准备绘图
    {
        CGContextSetInterpolationQuality(context, kCGInterpolationNone);
        
        if (!cv.drawCachedBitmap()) {               // 显示上次保存的缓冲图
            MgShapesLock locker([_gview doc], MgShapesLock::ReadOnly, 0);    // 锁定读取
            if (locker.locked()) {
                [self draw:&gs];                    // 不行则重新显示所有图形
                if (![self isZooming])              // 动态放缩时不保存显示内容
                    cv.saveCachedBitmap();          // 保存显示缓冲图，下次就不重新显示图形
                _shapeAdded = NULL;
            }
            else {
                nextDraw = true;
            }
        }
        else if (_shapeAdded) {                     // 在缓冲图上显示新的图形
            MgShapesLock locker([_gview doc], MgShapesLock::ReadOnly, 0);
            if (locker.locked()) {
                _shapeAdded->draw(0, gs);
                cv.saveCachedBitmap();              // 更新缓冲图
                _shapeAdded = NULL;
            }
            else {
                nextDraw = true;
            }
        }
        
        nextDraw = ![self dynDraw:&gs] || nextDraw; // 显示动态临时图形
        
        cv.endPaint();                              // 显示完成后贴到视图画布上
    }
    
    if (nextDraw) {
        [self setNeedsDisplay];
    }
}

- (void)shapeAdded:(MgShape*)shape
{
    if (_shapeAdded) {
        _cachedDraw = YES;
        [self regen];
    }
    else {
        _shapeAdded = shape;
        _cachedDraw = NO;
        [self setNeedsDisplay];
    }
}

- (BOOL)draw:(GiGraphics*)gs
{
    int count = 0;
    if ([_gview doc]) {
        count = [_gview doc]->draw(*gs);
    }
    return count > 0;
}

- (BOOL)dynDraw:(GiGraphics*)gs
{
    BOOL inactive = ![self isActiveView];
    BOOL locked = _lockRedraw && inactive;
    BOOL ret = YES;
    
    if (!locked && [_drawingDelegate respondsToSelector:@selector(dynDraw:)]) {
        ret = !![_drawingDelegate performSelector:@selector(dynDraw:) withObject:self];
    }
    
    bool antiAlias = gs->isAntiAliasMode();
    gs->setAntiAliasMode(false);
    
    if (_scale < 1) {
        GiContext ctx(0, GiColor(64, 64, 64, 172), kGiLineDot);
        UIView *v = [_gview ownerView];
        Box2d rect(Box2d(v.bounds.size.width, v.bounds.size.height)
                   * [_gview xform]->displayToWorld());
        gs->drawRect(&ctx, rect, false);
    }
    else if (inactive || !CGPointEqualToPoint(_zoomCenter, _pointW)) {
        GiContext ctx(0, GiColor(64, 64, 64, 172));
        Point2d ptd(Point2d(_zoomCenter.x, _zoomCenter.y) * _graph->xf.worldToDisplay());
        gs->rawLine(&ctx, ptd.x - 20, ptd.y, ptd.x + 20, ptd.y);
        gs->rawLine(&ctx, ptd.x, ptd.y - 20, ptd.x, ptd.y + 20);
    }
    
    gs->setAntiAliasMode(antiAlias);
    
    return ret;
}

- (void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event
{
    [_drawingDelegate touchesBegan:touches withEvent:event];    // for GiCommandController
    [super touchesBegan:touches withEvent:event];
}

- (void)touchesCancelled:(NSSet *)touches withEvent:(UIEvent *)event
{
    [_drawingDelegate touchesCancelled:touches withEvent:event];    // for GiCommandController
    [super touchesCancelled:touches withEvent:event];
}

- (BOOL)twoFingersPinch:(UIPinchGestureRecognizer *)sender
{
    if (sender.view == self && sender.state >= UIGestureRecognizerStateBegan) {
        if (sender.state == UIGestureRecognizerStateBegan) {
            _lastPt = [sender locationInView:sender.view];
        }
        else if (sender.scale > _MGZERO) {
            CGPoint pt = [sender locationInView:sender.view];
            float newscale = _scale / sender.scale;
            _zooming = (sender.state == UIGestureRecognizerStateChanged);
            
            if (_zooming && fabsf(sender.scale - 1) < 1e-2) {
                [self zoomPan:CGPointMake(_lastPt.x - pt.x, _lastPt.y - pt.y)];
            }
            else if (_zooming && (_scale > 1.f) == (newscale > 1.f)
                     && newscale > 0.1f && newscale < 10.f) {
                _scale = newscale;
                sender.scale = 1.f;
                
                [self updateTransform];
                _scale = _graph->xf.getViewScale() / [_gview xform]->getViewScale();
                
                if (!CGPointEqualToPoint(_zoomCenter, _pointW)) {
                    float off = (self.bounds.size.width - 10) / _graph->xf.getWorldToDisplayX();
                    _pointW.x = _zoomCenter.x + off / 2.f;
                    _graph->xf.zoom(Point2d(_pointW.x, _pointW.y), _graph->xf.getViewScale());
                }
                
                [self regen];
                [[_gview ownerView] setNeedsDisplay];
            }
            _lastPt = pt;
        }
    }
    
    return sender.view == self;
}

- (BOOL)twoFingersPan:(UIPanGestureRecognizer *)sender
{
    if (sender.view == self && sender.state >= UIGestureRecognizerStateBegan) {
        _zooming = (sender.state == UIGestureRecognizerStateChanged);
        if (sender.state > UIGestureRecognizerStateBegan) {
            CGPoint t = [sender translationInView:sender.view];
            [self zoomPan:CGPointMake(-t.x, -t.y)];
            [sender setTranslation:CGPointZero inView:sender.view];
        }
    }
    
    return sender.view == self;
}

- (BOOL)automoveSuperview:(CGPoint)point fromView:(UIView*)view
{
    CGPoint ptzoom = [self.superview convertPoint:point fromView:view]; // 在容器视图的坐标
    CGPoint cen = [self.superview.superview convertPoint:self.superview.center toView:view];
    BOOL intersected = CGRectContainsPoint(view.bounds, cen);   // 放大镜容器中心位于绘图视图内
    BOOL moved = NO;
    
    if (intersected     // 放大镜视图在实际绘图视图内 且 进入放大镜视图
        && CGRectContainsPoint(CGRectInset(self.superview.bounds, -30, -30), ptzoom))
    {
        CGRect limits = self.superview.superview.bounds;    // 放大镜容器视图的上级
        CGRect superframe = self.superview.frame;
        cen = self.superview.center;                        // 放大镜容器视图的中心点
        
        if (cen.x < limits.size.width / 2) {                // 移到右侧
            cen.x = limits.size.width - superframe.size.width / 2 - superframe.origin.x;
        }
        else {
            cen.x = (limits.size.width - superframe.origin.x - superframe.size.width
                     + superframe.size.width / 2);          // 移到左侧，取右边距为左边距
        }
        if (cen.y < limits.size.height / 2) {               // 移到下侧
            cen.y = limits.size.height - superframe.size.height / 2 - superframe.origin.y;
        }
        else {
            cen.y = (limits.size.height - superframe.origin.y - superframe.size.height
                     + superframe.size.height / 2);         // 移到上侧
        }
        
        moved = YES;
        
        [UIView beginAnimations:nil context:nil];
        [UIView setAnimationCurve:UIViewAnimationCurveLinear];
        [UIView setAnimationDuration:0.2];
        
        self.superview.center = cen;
        [UIView commitAnimations];
    }
    
    return moved;
}

@end
