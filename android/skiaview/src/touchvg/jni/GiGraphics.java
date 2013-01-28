/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.jni;

public class GiGraphics extends GiCanvasDrawing {
  private long swigCPtr;

  protected GiGraphics(long cPtr, boolean cMemoryOwn) {
    super(skiaviewJNI.GiGraphics_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(GiGraphics obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        skiaviewJNI.delete_GiGraphics(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public GiGraphics(GiTransform xform) {
    this(skiaviewJNI.new_GiGraphics(GiTransform.getCPtr(xform), xform), true);
  }

  public void copy(GiGraphics src) {
    skiaviewJNI.GiGraphics_copy(swigCPtr, this, GiGraphics.getCPtr(src), src);
  }

  public GiTransform xf() {
    return new GiTransform(skiaviewJNI.GiGraphics_xf(swigCPtr, this), false);
  }

  public boolean isDrawing() {
    return skiaviewJNI.GiGraphics_isDrawing(swigCPtr, this);
  }

  public boolean isPrint() {
    return skiaviewJNI.GiGraphics_isPrint(swigCPtr, this);
  }

  public Box2d getClipModel() {
    return new Box2d(skiaviewJNI.GiGraphics_getClipModel(swigCPtr, this), true);
  }

  public Box2d getClipWorld() {
    return new Box2d(skiaviewJNI.GiGraphics_getClipWorld(swigCPtr, this), true);
  }

  public RECT_2D getClipBox(RECT_2D rc) {
    return new RECT_2D(skiaviewJNI.GiGraphics_getClipBox(swigCPtr, this, RECT_2D.getCPtr(rc), rc), false);
  }

  public boolean setClipBox(RECT_2D rc) {
    return skiaviewJNI.GiGraphics_setClipBox(swigCPtr, this, RECT_2D.getCPtr(rc), rc);
  }

  public boolean setClipWorld(Box2d rectWorld) {
    return skiaviewJNI.GiGraphics_setClipWorld(swigCPtr, this, Box2d.getCPtr(rectWorld), rectWorld);
  }

  public GiColorMode getColorMode() {
    return GiColorMode.swigToEnum(skiaviewJNI.GiGraphics_getColorMode(swigCPtr, this));
  }

  public void setColorMode(GiColorMode mode) {
    skiaviewJNI.GiGraphics_setColorMode(swigCPtr, this, mode.swigValue());
  }

  public GiColor calcPenColor(GiColor color) {
    return new GiColor(skiaviewJNI.GiGraphics_calcPenColor(swigCPtr, this, GiColor.getCPtr(color), color), true);
  }

  public float calcPenWidth(float lineWidth, boolean useViewScale) {
    return skiaviewJNI.GiGraphics_calcPenWidth(swigCPtr, this, lineWidth, useViewScale);
  }

  public void setMaxPenWidth(float pixels, float minw) {
    skiaviewJNI.GiGraphics_setMaxPenWidth__SWIG_0(swigCPtr, this, pixels, minw);
  }

  public void setMaxPenWidth(float pixels) {
    skiaviewJNI.GiGraphics_setMaxPenWidth__SWIG_1(swigCPtr, this, pixels);
  }

  public boolean isAntiAliasMode() {
    return skiaviewJNI.GiGraphics_isAntiAliasMode(swigCPtr, this);
  }

  public boolean setAntiAliasMode(boolean antiAlias) {
    return skiaviewJNI.GiGraphics_setAntiAliasMode(swigCPtr, this, antiAlias);
  }

  public boolean drawLine(GiContext ctx, Point2d startPt, Point2d endPt, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawLine__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(startPt), startPt, Point2d.getCPtr(endPt), endPt, modelUnit);
  }

  public boolean drawLine(GiContext ctx, Point2d startPt, Point2d endPt) {
    return skiaviewJNI.GiGraphics_drawLine__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(startPt), startPt, Point2d.getCPtr(endPt), endPt);
  }

  public boolean drawLines(GiContext ctx, int count, Point2d points, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawLines__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points, modelUnit);
  }

  public boolean drawLines(GiContext ctx, int count, Point2d points) {
    return skiaviewJNI.GiGraphics_drawLines__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points);
  }

  public boolean drawBeziers(GiContext ctx, int count, Point2d points, boolean closed, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawBeziers__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points, closed, modelUnit);
  }

  public boolean drawBeziers(GiContext ctx, int count, Point2d points, boolean closed) {
    return skiaviewJNI.GiGraphics_drawBeziers__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points, closed);
  }

  public boolean drawBeziers(GiContext ctx, int count, Point2d points) {
    return skiaviewJNI.GiGraphics_drawBeziers__SWIG_2(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points);
  }

  public boolean drawArc(GiContext ctx, Point2d center, float rx, float ry, float startAngle, float sweepAngle, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawArc__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx, ry, startAngle, sweepAngle, modelUnit);
  }

  public boolean drawArc(GiContext ctx, Point2d center, float rx, float ry, float startAngle, float sweepAngle) {
    return skiaviewJNI.GiGraphics_drawArc__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx, ry, startAngle, sweepAngle);
  }

  public boolean drawArc3P(GiContext ctx, Point2d startpt, Point2d midpt, Point2d endpt, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawArc3P__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(startpt), startpt, Point2d.getCPtr(midpt), midpt, Point2d.getCPtr(endpt), endpt, modelUnit);
  }

  public boolean drawArc3P(GiContext ctx, Point2d startpt, Point2d midpt, Point2d endpt) {
    return skiaviewJNI.GiGraphics_drawArc3P__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(startpt), startpt, Point2d.getCPtr(midpt), midpt, Point2d.getCPtr(endpt), endpt);
  }

  public boolean drawPolygon(GiContext ctx, int count, Point2d points, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawPolygon__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points, modelUnit);
  }

  public boolean drawPolygon(GiContext ctx, int count, Point2d points) {
    return skiaviewJNI.GiGraphics_drawPolygon__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(points), points);
  }

  public boolean drawEllipse(GiContext ctx, Point2d center, float rx, float ry, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawEllipse__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx, ry, modelUnit);
  }

  public boolean drawEllipse(GiContext ctx, Point2d center, float rx, float ry) {
    return skiaviewJNI.GiGraphics_drawEllipse__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx, ry);
  }

  public boolean drawEllipse(GiContext ctx, Point2d center, float rx) {
    return skiaviewJNI.GiGraphics_drawEllipse__SWIG_2(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx);
  }

  public boolean drawEllipse(GiContext ctx, Box2d rect, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawEllipse__SWIG_3(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect, modelUnit);
  }

  public boolean drawEllipse(GiContext ctx, Box2d rect) {
    return skiaviewJNI.GiGraphics_drawEllipse__SWIG_4(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect);
  }

  public boolean drawPie(GiContext ctx, Point2d center, float rx, float ry, float startAngle, float sweepAngle, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawPie__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx, ry, startAngle, sweepAngle, modelUnit);
  }

  public boolean drawPie(GiContext ctx, Point2d center, float rx, float ry, float startAngle, float sweepAngle) {
    return skiaviewJNI.GiGraphics_drawPie__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(center), center, rx, ry, startAngle, sweepAngle);
  }

  public boolean drawRect(GiContext ctx, Box2d rect, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawRect__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect, modelUnit);
  }

  public boolean drawRect(GiContext ctx, Box2d rect) {
    return skiaviewJNI.GiGraphics_drawRect__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect);
  }

  public boolean drawRoundRect(GiContext ctx, Box2d rect, float rx, float ry, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawRoundRect__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect, rx, ry, modelUnit);
  }

  public boolean drawRoundRect(GiContext ctx, Box2d rect, float rx, float ry) {
    return skiaviewJNI.GiGraphics_drawRoundRect__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect, rx, ry);
  }

  public boolean drawRoundRect(GiContext ctx, Box2d rect, float rx) {
    return skiaviewJNI.GiGraphics_drawRoundRect__SWIG_2(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Box2d.getCPtr(rect), rect, rx);
  }

  public boolean drawSplines(GiContext ctx, int count, Point2d knots, Vector2d knotvs, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawSplines__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(knots), knots, Vector2d.getCPtr(knotvs), knotvs, modelUnit);
  }

  public boolean drawSplines(GiContext ctx, int count, Point2d knots, Vector2d knotvs) {
    return skiaviewJNI.GiGraphics_drawSplines__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(knots), knots, Vector2d.getCPtr(knotvs), knotvs);
  }

  public boolean drawClosedSplines(GiContext ctx, int count, Point2d knots, Vector2d knotvs, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawClosedSplines__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(knots), knots, Vector2d.getCPtr(knotvs), knotvs, modelUnit);
  }

  public boolean drawClosedSplines(GiContext ctx, int count, Point2d knots, Vector2d knotvs) {
    return skiaviewJNI.GiGraphics_drawClosedSplines__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(knots), knots, Vector2d.getCPtr(knotvs), knotvs);
  }

  public boolean drawBSplines(GiContext ctx, int count, Point2d ctlpts, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawBSplines__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(ctlpts), ctlpts, modelUnit);
  }

  public boolean drawBSplines(GiContext ctx, int count, Point2d ctlpts) {
    return skiaviewJNI.GiGraphics_drawBSplines__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(ctlpts), ctlpts);
  }

  public boolean drawClosedBSplines(GiContext ctx, int count, Point2d ctlpts, boolean modelUnit) {
    return skiaviewJNI.GiGraphics_drawClosedBSplines__SWIG_0(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(ctlpts), ctlpts, modelUnit);
  }

  public boolean drawClosedBSplines(GiContext ctx, int count, Point2d ctlpts) {
    return skiaviewJNI.GiGraphics_drawClosedBSplines__SWIG_1(swigCPtr, this, GiContext.getCPtr(ctx), ctx, count, Point2d.getCPtr(ctlpts), ctlpts);
  }

  public void clearCachedBitmap(boolean clearAll) {
    skiaviewJNI.GiGraphics_clearCachedBitmap__SWIG_0(swigCPtr, this, clearAll);
  }

  public void clearCachedBitmap() {
    skiaviewJNI.GiGraphics_clearCachedBitmap__SWIG_1(swigCPtr, this);
  }

  public float getScreenDpi() {
    return skiaviewJNI.GiGraphics_getScreenDpi(swigCPtr, this);
  }

  public GiColor getBkColor() {
    return new GiColor(skiaviewJNI.GiGraphics_getBkColor(swigCPtr, this), true);
  }

  public GiColor setBkColor(GiColor color) {
    return new GiColor(skiaviewJNI.GiGraphics_setBkColor(swigCPtr, this, GiColor.getCPtr(color), color), true);
  }

  public boolean rawLine(GiContext ctx, float x1, float y1, float x2, float y2) {
    return skiaviewJNI.GiGraphics_rawLine(swigCPtr, this, GiContext.getCPtr(ctx), ctx, x1, y1, x2, y2);
  }

  public boolean rawLines(GiContext ctx, Point2d pxs, int count) {
    return skiaviewJNI.GiGraphics_rawLines(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(pxs), pxs, count);
  }

  public boolean rawBeziers(GiContext ctx, Point2d pxs, int count) {
    return skiaviewJNI.GiGraphics_rawBeziers(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(pxs), pxs, count);
  }

  public boolean rawPolygon(GiContext ctx, Point2d pxs, int count) {
    return skiaviewJNI.GiGraphics_rawPolygon(swigCPtr, this, GiContext.getCPtr(ctx), ctx, Point2d.getCPtr(pxs), pxs, count);
  }

  public boolean rawRect(GiContext ctx, float x, float y, float w, float h) {
    return skiaviewJNI.GiGraphics_rawRect(swigCPtr, this, GiContext.getCPtr(ctx), ctx, x, y, w, h);
  }

  public boolean rawEllipse(GiContext ctx, float x, float y, float w, float h) {
    return skiaviewJNI.GiGraphics_rawEllipse(swigCPtr, this, GiContext.getCPtr(ctx), ctx, x, y, w, h);
  }

  public boolean rawBeginPath() {
    return skiaviewJNI.GiGraphics_rawBeginPath(swigCPtr, this);
  }

  public boolean rawEndPath(GiContext ctx, boolean fill) {
    return skiaviewJNI.GiGraphics_rawEndPath(swigCPtr, this, GiContext.getCPtr(ctx), ctx, fill);
  }

  public boolean rawMoveTo(float x, float y) {
    return skiaviewJNI.GiGraphics_rawMoveTo(swigCPtr, this, x, y);
  }

  public boolean rawLineTo(float x, float y) {
    return skiaviewJNI.GiGraphics_rawLineTo(swigCPtr, this, x, y);
  }

  public boolean rawBezierTo(float c1x, float c1y, float c2x, float c2y, float x, float y) {
    return skiaviewJNI.GiGraphics_rawBezierTo(swigCPtr, this, c1x, c1y, c2x, c2y, x, y);
  }

  public boolean rawClosePath() {
    return skiaviewJNI.GiGraphics_rawClosePath(swigCPtr, this);
  }

  public void rawTextCenter(String text, float x, float y, float h) {
    skiaviewJNI.GiGraphics_rawTextCenter(swigCPtr, this, text, x, y, h);
  }

  public boolean drawImage(String name, float xc, float yc, float w, float h, float angle) {
    return skiaviewJNI.GiGraphics_drawImage(swigCPtr, this, name, xc, yc, w, h, angle);
  }

}