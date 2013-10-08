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

public class Box2d : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Box2d(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Box2d obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Box2d() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_Box2d(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float xmin {
    set {
      touchvgPINVOKE.Box2d_xmin_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.Box2d_xmin_get(swigCPtr);
      return ret;
    } 
  }

  public float ymin {
    set {
      touchvgPINVOKE.Box2d_ymin_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.Box2d_ymin_get(swigCPtr);
      return ret;
    } 
  }

  public float xmax {
    set {
      touchvgPINVOKE.Box2d_xmax_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.Box2d_xmax_get(swigCPtr);
      return ret;
    } 
  }

  public float ymax {
    set {
      touchvgPINVOKE.Box2d_ymax_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.Box2d_ymax_get(swigCPtr);
      return ret;
    } 
  }

  public static Box2d kIdentity() {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_kIdentity(), false);
    return ret;
  }

  public Box2d() : this(touchvgPINVOKE.new_Box2d__SWIG_0(), true) {
  }

  public Box2d(Box2d src, bool normal) : this(touchvgPINVOKE.new_Box2d__SWIG_1(Box2d.getCPtr(src), normal), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(Box2d src) : this(touchvgPINVOKE.new_Box2d__SWIG_2(Box2d.getCPtr(src)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(Point2d pnt1, Point2d pnt2) : this(touchvgPINVOKE.new_Box2d__SWIG_3(Point2d.getCPtr(pnt1), Point2d.getCPtr(pnt2)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(float l, float t, float r, float b, bool normal) : this(touchvgPINVOKE.new_Box2d__SWIG_4(l, t, r, b, normal), true) {
  }

  public Box2d(float l, float t, float r, float b) : this(touchvgPINVOKE.new_Box2d__SWIG_5(l, t, r, b), true) {
  }

  public Box2d(RECT_2D rc, bool normal) : this(touchvgPINVOKE.new_Box2d__SWIG_6(RECT_2D.getCPtr(rc), normal), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(RECT_2D rc) : this(touchvgPINVOKE.new_Box2d__SWIG_7(RECT_2D.getCPtr(rc)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(int l, int t, int r, int b, bool normal) : this(touchvgPINVOKE.new_Box2d__SWIG_8(l, t, r, b, normal), true) {
  }

  public Box2d(int l, int t, int r, int b) : this(touchvgPINVOKE.new_Box2d__SWIG_9(l, t, r, b), true) {
  }

  public Box2d(Point2d pnt1, Point2d pnt2, Point2d pnt3, Point2d pnt4) : this(touchvgPINVOKE.new_Box2d__SWIG_10(Point2d.getCPtr(pnt1), Point2d.getCPtr(pnt2), Point2d.getCPtr(pnt3), Point2d.getCPtr(pnt4)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(int count, Point2d points) : this(touchvgPINVOKE.new_Box2d__SWIG_11(count, Point2d.getCPtr(points)), true) {
  }

  public Box2d(Point2d center, float width, float height) : this(touchvgPINVOKE.new_Box2d__SWIG_12(Point2d.getCPtr(center), width, height), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public Box2d(float width, float height) : this(touchvgPINVOKE.new_Box2d__SWIG_13(width, height), true) {
  }

  public void get(Point2d p1, Point2d p2) {
    touchvgPINVOKE.Box2d_get__SWIG_0(swigCPtr, Point2d.getCPtr(p1), Point2d.getCPtr(p2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public RECT_2D get(RECT_2D rc) {
    RECT_2D ret = new RECT_2D(touchvgPINVOKE.Box2d_get__SWIG_1(swigCPtr, RECT_2D.getCPtr(rc)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d set(Box2d src, bool normal) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_0(swigCPtr, Box2d.getCPtr(src), normal), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d set(Box2d src) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_1(swigCPtr, Box2d.getCPtr(src)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d set(Point2d p1, Point2d p2) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_2(swigCPtr, Point2d.getCPtr(p1), Point2d.getCPtr(p2)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d set(float x1, float y1, float x2, float y2) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_3(swigCPtr, x1, y1, x2, y2), false);
    return ret;
  }

  public Box2d set(Point2d p1, Point2d p2, Point2d p3, Point2d p4) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_4(swigCPtr, Point2d.getCPtr(p1), Point2d.getCPtr(p2), Point2d.getCPtr(p3), Point2d.getCPtr(p4)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d set(int count, Point2d points) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_5(swigCPtr, count, Point2d.getCPtr(points)), false);
    return ret;
  }

  public Box2d set(Point2d center, float width, float height) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_set__SWIG_6(swigCPtr, Point2d.getCPtr(center), width, height), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float width() {
    float ret = touchvgPINVOKE.Box2d_width(swigCPtr);
    return ret;
  }

  public float height() {
    float ret = touchvgPINVOKE.Box2d_height(swigCPtr);
    return ret;
  }

  public Vector2d size() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.Box2d_size(swigCPtr), true);
    return ret;
  }

  public Point2d center() {
    Point2d ret = new Point2d(touchvgPINVOKE.Box2d_center(swigCPtr), true);
    return ret;
  }

  public Point2d leftTop() {
    Point2d ret = new Point2d(touchvgPINVOKE.Box2d_leftTop(swigCPtr), true);
    return ret;
  }

  public Point2d rightTop() {
    Point2d ret = new Point2d(touchvgPINVOKE.Box2d_rightTop(swigCPtr), true);
    return ret;
  }

  public Point2d leftBottom() {
    Point2d ret = new Point2d(touchvgPINVOKE.Box2d_leftBottom(swigCPtr), true);
    return ret;
  }

  public Point2d rightBottom() {
    Point2d ret = new Point2d(touchvgPINVOKE.Box2d_rightBottom(swigCPtr), true);
    return ret;
  }

  public Box2d normalize() {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_normalize(swigCPtr), false);
    return ret;
  }

  public Box2d swapTopBottom() {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_swapTopBottom(swigCPtr), false);
    return ret;
  }

  public Box2d empty() {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_empty(swigCPtr), false);
    return ret;
  }

  public bool isNormalized() {
    bool ret = touchvgPINVOKE.Box2d_isNormalized(swigCPtr);
    return ret;
  }

  public bool isNull() {
    bool ret = touchvgPINVOKE.Box2d_isNull(swigCPtr);
    return ret;
  }

  public bool isEmpty(Tol tol, bool useOr) {
    bool ret = touchvgPINVOKE.Box2d_isEmpty__SWIG_0(swigCPtr, Tol.getCPtr(tol), useOr);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEmpty(Tol tol) {
    bool ret = touchvgPINVOKE.Box2d_isEmpty__SWIG_1(swigCPtr, Tol.getCPtr(tol));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEmpty() {
    bool ret = touchvgPINVOKE.Box2d_isEmpty__SWIG_2(swigCPtr);
    return ret;
  }

  public bool isEmptyMinus(Tol tol) {
    bool ret = touchvgPINVOKE.Box2d_isEmptyMinus__SWIG_0(swigCPtr, Tol.getCPtr(tol));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEmptyMinus() {
    bool ret = touchvgPINVOKE.Box2d_isEmptyMinus__SWIG_1(swigCPtr);
    return ret;
  }

  public bool contains(Point2d pt) {
    bool ret = touchvgPINVOKE.Box2d_contains__SWIG_0(swigCPtr, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool contains(Point2d pt, Tol tol) {
    bool ret = touchvgPINVOKE.Box2d_contains__SWIG_1(swigCPtr, Point2d.getCPtr(pt), Tol.getCPtr(tol));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool contains(Box2d box) {
    bool ret = touchvgPINVOKE.Box2d_contains__SWIG_2(swigCPtr, Box2d.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool contains(Box2d box, Tol tol) {
    bool ret = touchvgPINVOKE.Box2d_contains__SWIG_3(swigCPtr, Box2d.getCPtr(box), Tol.getCPtr(tol));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d inflate(float d) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_inflate__SWIG_0(swigCPtr, d), false);
    return ret;
  }

  public Box2d inflate(float x, float y) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_inflate__SWIG_1(swigCPtr, x, y), false);
    return ret;
  }

  public Box2d inflate(Vector2d vec) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_inflate__SWIG_2(swigCPtr, Vector2d.getCPtr(vec)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d inflate(Box2d box) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_inflate__SWIG_3(swigCPtr, Box2d.getCPtr(box)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d inflate(float l, float b, float r, float t) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_inflate__SWIG_4(swigCPtr, l, b, r, t), false);
    return ret;
  }

  public Box2d deflate(float d) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_deflate__SWIG_0(swigCPtr, d), false);
    return ret;
  }

  public Box2d deflate(float x, float y) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_deflate__SWIG_1(swigCPtr, x, y), false);
    return ret;
  }

  public Box2d deflate(Vector2d vec) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_deflate__SWIG_2(swigCPtr, Vector2d.getCPtr(vec)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d deflate(Box2d box) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_deflate__SWIG_3(swigCPtr, Box2d.getCPtr(box)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d deflate(float l, float b, float r, float t) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_deflate__SWIG_4(swigCPtr, l, b, r, t), false);
    return ret;
  }

  public Box2d offset(float x, float y) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_offset__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public Box2d offset(Vector2d vec) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_offset__SWIG_1(swigCPtr, Vector2d.getCPtr(vec)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d scaleBy(float sx, float sy) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_scaleBy__SWIG_0(swigCPtr, sx, sy), false);
    return ret;
  }

  public Box2d scaleBy(float sx) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_scaleBy__SWIG_1(swigCPtr, sx), false);
    return ret;
  }

  public bool isIntersect(Box2d box) {
    bool ret = touchvgPINVOKE.Box2d_isIntersect(swigCPtr, Box2d.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d intersectWith(Box2d r1, Box2d r2) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_intersectWith__SWIG_0(swigCPtr, Box2d.getCPtr(r1), Box2d.getCPtr(r2)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d intersectWith(Box2d box) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_intersectWith__SWIG_1(swigCPtr, Box2d.getCPtr(box)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d unionWith(Box2d r1, Box2d r2) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_unionWith__SWIG_0(swigCPtr, Box2d.getCPtr(r1), Box2d.getCPtr(r2)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d unionWith(Box2d box) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_unionWith__SWIG_1(swigCPtr, Box2d.getCPtr(box)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d unionWith(float x, float y) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_unionWith__SWIG_2(swigCPtr, x, y), false);
    return ret;
  }

  public Box2d unionWith(Point2d pt) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_unionWith__SWIG_3(swigCPtr, Point2d.getCPtr(pt)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d offset(Box2d box) {
    Box2d ret = new Box2d(touchvgPINVOKE.Box2d_offset__SWIG_2(swigCPtr, Box2d.getCPtr(box)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEqualTo(Box2d box, Tol tol) {
    bool ret = touchvgPINVOKE.Box2d_isEqualTo__SWIG_0(swigCPtr, Box2d.getCPtr(box), Tol.getCPtr(tol));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEqualTo(Box2d box) {
    bool ret = touchvgPINVOKE.Box2d_isEqualTo__SWIG_1(swigCPtr, Box2d.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
