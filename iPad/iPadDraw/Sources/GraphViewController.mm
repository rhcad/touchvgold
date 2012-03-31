// GraphViewController.mm
// Created by Zhang Yungui on 2012-3-2.

#import "GraphViewController.h"

#ifdef TEST_SIMPLE_VIEW
#import "TestGraphView.h"

@implementation GraphViewController

- (void)loadView
{
    CGRect rect = [[UIScreen mainScreen] applicationFrame];
    rect.origin.y = 0;
    UIView *view = [[TestGraphView alloc]initWithFrame:rect];
    self.view = view;
    [view release];
}

@end

#else

#import "SCCalloutView.h"
#import <GraphView/GiGraphView.h>

// SCCalloutGraphView

@interface SCCalloutGraphView : SCCalloutView
{
    GiViewController    *_graph;
}
@property (nonatomic,readonly)  GiViewController *graph;
@end

@implementation SCCalloutGraphView
@synthesize graph = _graph;

- (id)initWithFrame:(CGRect)frame
{
    self = [super initWithFrame:frame];
    if (self) {
        _graph = [[GiViewController alloc]init];
    }
    return self;
}

- (void)dealloc
{
    [_graph release];
    [super dealloc];
}

@end

// GraphViewController

static const NSUInteger kRedTag         = 0;
static const NSUInteger kBlueTag        = 1;
static const NSUInteger kYellowTag      = 2;
static const NSUInteger kLineTag        = 3;
static const NSUInteger kDashLineTag    = 4;

@implementation GraphViewController

- (void)dealloc
{
    [_graph release];
    [super dealloc];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
}

- (void)clearCachedData
{
    [_graph clearCachedData];
}

- (void)loadView
{
    CGRect rect = [[UIScreen mainScreen] applicationFrame];
    CGFloat BAR_HEIGHT = rect.size.height > 1000 ? 50 : 40;
    CGFloat BTN_XDIFF  = rect.size.height > 1000 ? 10 : 0;
    
    UIView *mainview = [[UIView alloc]initWithFrame:rect];
    self.view = mainview;
    self.view.backgroundColor = [UIColor clearColor];
    [mainview release];
    rect.origin.y = 0;
    
    CGRect viewFrame = rect;
    viewFrame.size.height -= BAR_HEIGHT;
    
    _graph = [[GiViewController alloc]init];
    [_graph createGraphView:viewFrame backgroundColor:[UIColor grayColor] shapes:NULL];
    [self.view addSubview:_graph.view];
    
    UIView *magnifierView = [[UIView alloc]initWithFrame:CGRectMake(10, 10, 250, 250)];
    magnifierView.backgroundColor = [UIColor colorWithRed:0.6f green:0.7f blue:0.6f alpha:0.9f];
    [self.view addSubview:magnifierView];
    [magnifierView release];
    
    CGFloat magbtnw = 32;
    CGRect magbarRect = CGRectMake(0, 0, magnifierView.bounds.size.width, magbtnw);
    UIButton *magbarView = [[UIButton alloc]initWithFrame:magbarRect];
    [magbarView setImage:[UIImage imageNamed:@"downview.png"] forState: UIControlStateNormal];
	magbarView.alpha = 0.6;
    magbarView.autoresizingMask = UIViewAutoresizingFlexibleWidth;
	[magnifierView addSubview:magbarView];
    [magbarView release];
    
    CGRect maggraphRect = magnifierView.bounds;
    maggraphRect.origin.y = magbtnw;
    maggraphRect.size.height -= magbtnw;
    UIView *magView = [_graph createMagnifierView:magnifierView frame:maggraphRect scale:4];
    magView.autoresizingMask = (UIViewAutoresizingFlexibleWidth | UIViewAutoresizingFlexibleHeight
                                | UIViewAutoresizingFlexibleLeftMargin | UIViewAutoresizingFlexibleRightMargin
                                | UIViewAutoresizingFlexibleBottomMargin);
    
    CGFloat magbtnx = 4;
    [self addButton:@"back.png" action:@selector(lockMagnifier:) bar:magbarView x:&magbtnx size:magbtnw diffx:4];
    [self addButton:@"clearview.png" action:@selector(resizeMagnifier:) bar:magbarView x:&magbtnx size:magbtnw diffx:4];
    
    CGRect barFrame = rect;
    barFrame.size.height = BAR_HEIGHT;
    barFrame.origin.y = viewFrame.size.height;
    
    _downview = [[UIButton alloc]initWithFrame:barFrame];
    [_downview setImage:[UIImage imageNamed:@"downview.png"] forState: UIControlStateNormal];
	_downview.alpha = 0.6;
	[self.view addSubview:_downview];
    [_downview release];
    
    CGFloat btnx = barFrame.size.width / 2 - (BTN_XDIFF + BAR_HEIGHT) * 4;
    redBtn = [self addButton:@"redbrush.png" action:@selector(colorBtnPress:)
                         bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
    redBtn.tag = kRedTag;
    
    blueBtn = [self addButton:@"bluebrush.png" action:@selector(colorBtnPress:)
                          bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
    blueBtn.tag = kBlueTag;
    
    yellowbtn = [self addButton:@"yellowbrush.png" action:@selector(colorBtnPress:)
                            bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
    yellowbtn.tag = kYellowTag;
    
    colorbtn = [self addButton:@"colormix.png" action:@selector(showPaletee:)
                           bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
    
    brushbtn = [self addButton:@"brush.png" action:@selector(showPenView:)
                           bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];	
    
    erasebtn = [self addButton:@"erase.png" action:@selector(eraseColor:)
                           bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
    
    clearbtn = [self addButton:@"clearview.png" action:@selector(clearView:)
                           bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
    
    backbtn  = [self addButton:@"back.png" action:@selector(backToView:)
                           bar:_downview x:&btnx size:BAR_HEIGHT diffx:BTN_XDIFF];
}

- (UIButton *)addButton:(NSString *)imgname action:(SEL)action bar:(UIView*)bar
                      x:(CGFloat*)x size:(CGFloat)size diffx:(CGFloat)diffx
{
    UIButton *btn = [[UIButton alloc]initWithFrame:CGRectMake(*x, 0, size, size)];
    [btn setImage:[UIImage imageNamed:imgname] forState: UIControlStateNormal];
    [btn addTarget:self action:action forControlEvents:UIControlEventTouchUpInside];
    [bar addSubview:btn];
    [btn release];
    *x += size + diffx;
    return btn;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    [self colorBtnPress:yellowbtn];
}

- (IBAction)lockMagnifier:(id)sender
{
    GiMagnifierView *magnifierView = (GiMagnifierView*)_graph.magnifierView;
    magnifierView.lockRedraw = !magnifierView.lockRedraw;
}

- (IBAction)resizeMagnifier:(id)sender
{
    UIView *mview = _graph.magnifierView.superview;
    CGSize totalsize = _graph.view.bounds.size;
    CGSize size = mview.frame.size;
    
    if (size.width > totalsize.width - 20 || size.height > totalsize.height - 20)
        mview.frame = CGRectMake(10, 10, 100, 100);
    else if (size.width > totalsize.width * 0.75f || size.height > totalsize.height * 0.75f)
        mview.frame = _graph.view.bounds;
    else {
        size = CGSizeMake(size.width * 2, size.height * 2);
        if (size.width > totalsize.width - 20 || size.height > totalsize.height - 20)
            mview.frame = _graph.view.bounds;
        else
            mview.frame = CGRectMake(10, 10, size.width, size.height);
    }
}

- (IBAction)showPenView:(id)sender
{
	UIButton* btnsrc = (UIButton*)sender;
    
	[self showUnlightButtons];
	[brushbtn setImage:[UIImage imageNamed:@"brush1.png"] forState:UIControlStateNormal]; // brush 图标加亮
    
    CGRect btnrect = [btnsrc convertRect:btnsrc.bounds toView:self.view];
    CGRect viewrect = CGRectMake(0, 0, 239, 177);
    viewrect.origin.x = btnrect.origin.x + btnrect.size.width / 2 - viewrect.size.width / 2;
    viewrect.origin.y = btnrect.origin.y - viewrect.size.height;
    
	SCCalloutView *calloutView = [[SCCalloutView alloc]initWithFrame:viewrect];
    [calloutView setImage:[UIImage imageNamed:@"brushoption.png"] forState: UIControlStateNormal];
    [self.view addSubview:calloutView];
    [calloutView release];
    
    UISlider *sliderWidth = [[UISlider alloc] initWithFrame:CGRectMake(14,20,211, 40)];
	[sliderWidth addTarget:self action:@selector(lineWidthChange:) forControlEvents:UIControlEventValueChanged];
    sliderWidth.value = _graph.lineWidth / 500.0f;    
	[calloutView addSubview:sliderWidth];
	[sliderWidth release];
	
	UISlider *sliderAlpha = [[UISlider alloc]initWithFrame:CGRectMake(14, 60, 211, 40)];
	[sliderAlpha addTarget:self action:@selector(alphaChange:) forControlEvents:UIControlEventValueChanged];
    sliderAlpha.value = _graph.lineAlpha;
	[calloutView addSubview:sliderAlpha];
	[sliderAlpha release];
	
	UIButton *linebtn = [[UIButton alloc]initWithFrame:CGRectMake(14, 105, 63, 31)];
	[linebtn setImage:[UIImage imageNamed:@"line.png"] forState:UIControlStateNormal];
	[linebtn addTarget:self action:@selector(colorBtnPress:) forControlEvents:UIControlEventTouchUpInside];
	linebtn.tag = kLineTag;
	[calloutView addSubview:linebtn];
	[linebtn release];
	
	UIButton *dashlinebtn = [[UIButton alloc]initWithFrame:CGRectMake(84, 105, 63, 31)];
	[dashlinebtn setImage:[UIImage imageNamed:@"dashline.png"] forState:UIControlStateNormal];
	[dashlinebtn addTarget:self action:@selector(colorBtnPress:) forControlEvents:UIControlEventTouchUpInside];
	dashlinebtn.tag = kDashLineTag;
	[calloutView addSubview:dashlinebtn];
	[dashlinebtn release];
	
	UIButton *freebrush = [[UIButton alloc]initWithFrame:CGRectMake(154, 92, 63, 44)];
	[freebrush setImage:[UIImage imageNamed:@"freedraw.png"] forState:UIControlStateNormal];
	[freebrush addTarget:self action:@selector(backtoDraw:) forControlEvents:UIControlEventTouchUpInside];
	[calloutView addSubview:freebrush];
	[freebrush release];
}

- (IBAction)colorBtnPress:(id)sender
{
	UIButton* btn = (UIButton*)sender;
    
	switch (btn.tag)
	{
		case kRedTag:
			[self showUnlightButtons];
            [redBtn setImage:[UIImage imageNamed:@"redbrush1.png"] forState: UIControlStateNormal]; // 切换至红色画笔
            _graph.lineColor = [UIColor redColor];
            _graph.commandName = "splines";
			break;
		case kBlueTag:
		    [self showUnlightButtons];
            [blueBtn setImage:[UIImage imageNamed:@"bluebrush1.png"] forState: UIControlStateNormal]; // 切换至蓝色画笔
            _graph.lineColor = [UIColor blueColor];
            _graph.commandName = "splines";
			break;
        case kYellowTag:
		    [self showUnlightButtons];
            [yellowbtn setImage:[UIImage imageNamed:@"yellowbrush1.png"] forState: UIControlStateNormal]; // 切换至黄色画笔
            _graph.lineColor = [UIColor yellowColor];
            _graph.commandName = "splines";
			break;
		case kLineTag:              // 画直线
            _graph.lineStyle = 0;
			break;
		case kDashLineTag:          // 画虚线
            _graph.lineStyle = 1;
			break;
		default:
			break;
	}
}

- (IBAction)lineWidthChange:(id)sender // 线条宽度调整
{
    UISlider *slider = (UISlider *)sender;
    _graph.lineWidth = 500.0f * slider.value;
}

- (IBAction)alphaChange:(id)sender  // 透明度调整
{
    UISlider *slider = (UISlider *)sender;
    _graph.lineAlpha = slider.value;
}

- (IBAction)showPaletee:(id)sender  // 显示调色板
{
    [self showUnlightButtons];
	[colorbtn setImage:[UIImage imageNamed:@"colormix1"] forState:UIControlStateNormal]; // 图标加亮
    
    CGRect viewrect = CGRectMake(0, 0, 298+40, 257+60);
    viewrect.origin.x = (self.view.bounds.size.width - viewrect.size.width) / 2;
    viewrect.origin.y = self.view.bounds.size.height - viewrect.size.height - _downview.frame.size.height - 20;
    
	SCCalloutGraphView *calloutView = [[SCCalloutGraphView alloc]initWithFrame:viewrect];
    [self.view addSubview:calloutView];
    [calloutView release];
    
    UIButton *wrapview = [[UIButton alloc]initWithFrame:calloutView.bounds];
    wrapview.backgroundColor = [UIColor darkGrayColor];
    [wrapview addTarget:self action:@selector(colorMapPress:) forControlEvents:UIControlEventTouchDragInside];
    [calloutView addSubview:wrapview];
    [wrapview release];
    
    UIButton *mapbtn = [[UIButton alloc]initWithFrame:CGRectMake(20, 20, 298, 257)];
	[mapbtn setImage:[UIImage imageNamed:@"colormap.png"] forState:UIControlStateNormal];
	[wrapview addSubview:mapbtn];
	[mapbtn release];
    
    [calloutView.graph createSubGraphView:mapbtn frame:mapbtn.bounds shapes:_graph.shapes];
    calloutView.graph.commandName = "splines";
}

- (IBAction)colorMapPress:(id)sender
{
    //UIControl* btn = (UIControl*)sender;
}

- (IBAction)backtoDraw:(id)sender   // 返回自由画图
{
    UIControl *btn = (UIControl *)sender;
    [btn.superview removeFromSuperview];
}

- (IBAction)eraseColor:(id)sender   // 切换至橡皮擦
{
	[self showUnlightButtons];
	[erasebtn setImage:[UIImage imageNamed:@"erase1.png"] forState:UIControlStateNormal];
    
    _graph.commandName = "erase";
}

- (IBAction)clearView:(id)sender    // 清屏
{
    _graph.commandName = "lines";
}

- (IBAction)backToView:(id)sender   // 退出自由绘图
{
    [self showUnlightButtons];
    [backbtn setImage:[UIImage imageNamed:@"back1.png"] forState:UIControlStateNormal];
    _graph.commandName = "select";
}

- (void)showUnlightButtons          // 显示全部非高亮钮
{
	[redBtn    setImage:[UIImage imageNamed:@"redbrush.png"] forState: UIControlStateNormal];
	[blueBtn   setImage:[UIImage imageNamed:@"bluebrush.png"] forState: UIControlStateNormal];
	[yellowbtn setImage:[UIImage imageNamed:@"yellowbrush.png"] forState: UIControlStateNormal];
	[colorbtn  setImage:[UIImage imageNamed:@"colormix.png"] forState:UIControlStateNormal];
	[brushbtn  setImage:[UIImage imageNamed:@"brush.png"] forState:UIControlStateNormal];
	[erasebtn  setImage:[UIImage imageNamed:@"erase.png"] forState:UIControlStateNormal];
    [backbtn   setImage:[UIImage imageNamed:@"back.png"] forState:UIControlStateNormal];
}

@end

#endif // TEST_SIMPLE_VIEW
