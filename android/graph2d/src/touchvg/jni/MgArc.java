/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.jni;

public class MgArc extends MgBaseShape {
  private long swigCPtr;

  protected MgArc(long cPtr, boolean cMemoryOwn) {
    super(graph2dJNI.MgArc_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgArc obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        graph2dJNI.delete_MgArc(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MgArc() {
    this(graph2dJNI.new_MgArc(), true);
  }

  public static MgArc create() {
    long cPtr = graph2dJNI.MgArc_create();
    return (cPtr == 0) ? null : new MgArc(cPtr, false);
  }

  public static int Type() {
    return graph2dJNI.MgArc_Type();
  }

  public Point2d getCenter() {
    return new Point2d(graph2dJNI.MgArc_getCenter(swigCPtr, this), true);
  }

  public Point2d getStartPoint() {
    return new Point2d(graph2dJNI.MgArc_getStartPoint(swigCPtr, this), true);
  }

  public Point2d getEndPoint() {
    return new Point2d(graph2dJNI.MgArc_getEndPoint(swigCPtr, this), true);
  }

  public Point2d getMidPoint() {
    return new Point2d(graph2dJNI.MgArc_getMidPoint(swigCPtr, this), true);
  }

  public float getRadius() {
    return graph2dJNI.MgArc_getRadius(swigCPtr, this);
  }

  public float getStartAngle() {
    return graph2dJNI.MgArc_getStartAngle(swigCPtr, this);
  }

  public float getEndAngle() {
    return graph2dJNI.MgArc_getEndAngle(swigCPtr, this);
  }

  public float getSweepAngle() {
    return graph2dJNI.MgArc_getSweepAngle(swigCPtr, this);
  }

  public Vector2d getStartTangent() {
    return new Vector2d(graph2dJNI.MgArc_getStartTangent(swigCPtr, this), true);
  }

  public Vector2d getEndTangent() {
    return new Vector2d(graph2dJNI.MgArc_getEndTangent(swigCPtr, this), true);
  }

  public boolean setStartMidEnd(Point2d start, Point2d point, Point2d end) {
    return graph2dJNI.MgArc_setStartMidEnd(swigCPtr, this, Point2d.getCPtr(start), start, Point2d.getCPtr(point), point, Point2d.getCPtr(end), end);
  }

  public boolean setCenterStartEnd(Point2d center, Point2d start, Point2d end) {
    return graph2dJNI.MgArc_setCenterStartEnd(swigCPtr, this, Point2d.getCPtr(center), center, Point2d.getCPtr(start), start, Point2d.getCPtr(end), end);
  }

  public boolean setTanStartEnd(Vector2d startTan, Point2d start, Point2d end) {
    return graph2dJNI.MgArc_setTanStartEnd(swigCPtr, this, Vector2d.getCPtr(startTan), startTan, Point2d.getCPtr(start), start, Point2d.getCPtr(end), end);
  }

  public boolean setCenterRadius(Point2d center, float radius, float startAngle, float sweepAngle) {
    return graph2dJNI.MgArc_setCenterRadius(swigCPtr, this, Point2d.getCPtr(center), center, radius, startAngle, sweepAngle);
  }

}
