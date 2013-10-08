/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class Point2d : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Point2d(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Point2d obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Point2d() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_Point2d(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float x {
    set {
      touchvgPINVOKE.Point2d_x_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.Point2d_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      touchvgPINVOKE.Point2d_y_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.Point2d_y_get(swigCPtr);
      return ret;
    } 
  }

  public static Point2d kOrigin() {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_kOrigin(), false);
    return ret;
  }

  public Point2d() : this(touchvgPINVOKE.new_Point2d__SWIG_0(), true) {
  }

  public Point2d(float xx, float yy) : this(touchvgPINVOKE.new_Point2d__SWIG_1(xx, yy), true) {
  }

  public Point2d(Point2d src) : this(touchvgPINVOKE.new_Point2d__SWIG_2(Point2d.getCPtr(src)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Point2d transform(Matrix2d m) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_transform(swigCPtr, Matrix2d.getCPtr(m)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d scaleBy(float sx, float sy) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_scaleBy__SWIG_0(swigCPtr, sx, sy), false);
    return ret;
  }

  public Point2d scaleBy(float s) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_scaleBy__SWIG_1(swigCPtr, s), false);
    return ret;
  }

  public void offset(float dx, float dy) {
    touchvgPINVOKE.Point2d_offset__SWIG_0(swigCPtr, dx, dy);
  }

  public void offset(Vector2d vec) {
    touchvgPINVOKE.Point2d_offset__SWIG_1(swigCPtr, Vector2d.getCPtr(vec));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Point2d add(Point2d pnt) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_add(swigCPtr, Point2d.getCPtr(pnt)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2d subtract(Point2d pnt) {
    Vector2d ret = new Vector2d(touchvgPINVOKE.Point2d_subtract__SWIG_0(swigCPtr, Point2d.getCPtr(pnt)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d subtract(Vector2d vec) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_subtract__SWIG_1(swigCPtr, Vector2d.getCPtr(vec)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector2d negate() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.Point2d_negate(swigCPtr), true);
    return ret;
  }

  public Vector2d asVector() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.Point2d_asVector(swigCPtr), true);
    return ret;
  }

  public float length() {
    float ret = touchvgPINVOKE.Point2d_length(swigCPtr);
    return ret;
  }

  public float distanceTo(Point2d pnt) {
    float ret = touchvgPINVOKE.Point2d_distanceTo(swigCPtr, Point2d.getCPtr(pnt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float distanceSquare(Point2d pnt) {
    float ret = touchvgPINVOKE.Point2d_distanceSquare(swigCPtr, Point2d.getCPtr(pnt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEqualTo(Point2d pnt, Tol tol) {
    bool ret = touchvgPINVOKE.Point2d_isEqualTo__SWIG_0(swigCPtr, Point2d.getCPtr(pnt), Tol.getCPtr(tol));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEqualTo(Point2d pnt) {
    bool ret = touchvgPINVOKE.Point2d_isEqualTo__SWIG_1(swigCPtr, Point2d.getCPtr(pnt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d set(float xx, float yy) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_set(swigCPtr, xx, yy), false);
    return ret;
  }

  public Point2d polarPoint(float angle, float dist) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_polarPoint(swigCPtr, angle, dist), true);
    return ret;
  }

  public Point2d rulerPoint(Point2d dir, float yoff) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_rulerPoint__SWIG_0(swigCPtr, Point2d.getCPtr(dir), yoff), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d rulerPoint(Point2d dir, float xoff, float yoff) {
    Point2d ret = new Point2d(touchvgPINVOKE.Point2d_rulerPoint__SWIG_1(swigCPtr, Point2d.getCPtr(dir), xoff, yoff), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
