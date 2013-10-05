/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.core;

public class MgBaseRect extends MgBaseShape {
  private long swigCPtr;

  protected MgBaseRect(long cPtr, boolean cMemoryOwn) {
    super(touchvgJNI.MgBaseRect_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgBaseRect obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        touchvgJNI.delete_MgBaseRect(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public static int Type() {
    return touchvgJNI.MgBaseRect_Type();
  }

  public Point2d getCenter() {
    return new Point2d(touchvgJNI.MgBaseRect_getCenter(swigCPtr, this), true);
  }

  public Box2d getRect() {
    return new Box2d(touchvgJNI.MgBaseRect_getRect(swigCPtr, this), true);
  }

  public float getWidth() {
    return touchvgJNI.MgBaseRect_getWidth(swigCPtr, this);
  }

  public float getHeight() {
    return touchvgJNI.MgBaseRect_getHeight(swigCPtr, this);
  }

  public float getAngle() {
    return touchvgJNI.MgBaseRect_getAngle(swigCPtr, this);
  }

  public boolean isEmpty(float minDist) {
    return touchvgJNI.MgBaseRect_isEmpty(swigCPtr, this, minDist);
  }

  public boolean isOrtho() {
    return touchvgJNI.MgBaseRect_isOrtho(swigCPtr, this);
  }

  public void setRect2P(Point2d pt1, Point2d pt2) {
    touchvgJNI.MgBaseRect_setRect2P(swigCPtr, this, Point2d.getCPtr(pt1), pt1, Point2d.getCPtr(pt2), pt2);
  }

  public void setRectWithAngle(Point2d pt1, Point2d pt2, float angle, Point2d basept) {
    touchvgJNI.MgBaseRect_setRectWithAngle(swigCPtr, this, Point2d.getCPtr(pt1), pt1, Point2d.getCPtr(pt2), pt2, angle, Point2d.getCPtr(basept), basept);
  }

  public void setRect4P(Point2d points) {
    touchvgJNI.MgBaseRect_setRect4P(swigCPtr, this, Point2d.getCPtr(points), points);
  }

  public void setCenter(Point2d pt) {
    touchvgJNI.MgBaseRect_setCenter(swigCPtr, this, Point2d.getCPtr(pt), pt);
  }

  public void setSquare(boolean square) {
    touchvgJNI.MgBaseRect_setSquare(swigCPtr, this, square);
  }

}