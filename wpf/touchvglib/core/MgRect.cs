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

public class MgRect : MgBaseRect {
  private HandleRef swigCPtr;

  internal MgRect(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgRect_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgRect obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgRect() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgRect(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgRect() : this(touchvgPINVOKE.new_MgRect(), true) {
  }

  public static MgRect create() {
    IntPtr cPtr = touchvgPINVOKE.MgRect_create();
    MgRect ret = (cPtr == IntPtr.Zero) ? null : new MgRect(cPtr, false);
    return ret;
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgRect_Type();
    return ret;
  }

  public override string getTypeName() {
    string ret = touchvgPINVOKE.MgRect_getTypeName(swigCPtr);
    return ret;
  }

  public override MgObject clone() {
    IntPtr cPtr = touchvgPINVOKE.MgRect_clone(swigCPtr);
    MgObject ret = (cPtr == IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgRect_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgRect_release(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgRect_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgRect_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgRect_isKindOf(swigCPtr, type);
    return ret;
  }

  public override Box2d getExtent() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgRect_getExtent(swigCPtr), true);
    return ret;
  }

  public override void update() {
    touchvgPINVOKE.MgRect_update(swigCPtr);
  }

  public override void transform(Matrix2d mat) {
    touchvgPINVOKE.MgRect_transform(swigCPtr, Matrix2d.getCPtr(mat));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void clear() {
    touchvgPINVOKE.MgRect_clear(swigCPtr);
  }

  public override void clearCachedData() {
    touchvgPINVOKE.MgRect_clearCachedData(swigCPtr);
  }

  public override int getPointCount() {
    int ret = touchvgPINVOKE.MgRect_getPointCount(swigCPtr);
    return ret;
  }

  public override Point2d getPoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgRect_getPoint(swigCPtr, index), true);
    return ret;
  }

  public override void setPoint(int index, Point2d pt) {
    touchvgPINVOKE.MgRect_setPoint(swigCPtr, index, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isClosed() {
    bool ret = touchvgPINVOKE.MgRect_isClosed(swigCPtr);
    return ret;
  }

  public override bool hitTestBox(Box2d rect) {
    bool ret = touchvgPINVOKE.MgRect_hitTestBox(swigCPtr, Box2d.getCPtr(rect));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool draw(int mode, GiGraphics gs, GiContext ctx, int segment) {
    bool ret = touchvgPINVOKE.MgRect_draw(swigCPtr, mode, GiGraphics.getCPtr(gs), GiContext.getCPtr(ctx), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool save(MgStorage s) {
    bool ret = touchvgPINVOKE.MgRect_save(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public override bool load(MgShapeFactory factory, MgStorage s) {
    bool ret = touchvgPINVOKE.MgRect_load(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s));
    return ret;
  }

  public override int getHandleCount() {
    int ret = touchvgPINVOKE.MgRect_getHandleCount(swigCPtr);
    return ret;
  }

  public override Point2d getHandlePoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgRect_getHandlePoint(swigCPtr, index), true);
    return ret;
  }

  public override bool setHandlePoint(int index, Point2d pt, float tol) {
    bool ret = touchvgPINVOKE.MgRect_setHandlePoint(swigCPtr, index, Point2d.getCPtr(pt), tol);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isHandleFixed(int index) {
    bool ret = touchvgPINVOKE.MgRect_isHandleFixed(swigCPtr, index);
    return ret;
  }

  public override int getHandleType(int index) {
    int ret = touchvgPINVOKE.MgRect_getHandleType(swigCPtr, index);
    return ret;
  }

  public override bool offset(Vector2d vec, int segment) {
    bool ret = touchvgPINVOKE.MgRect_offset(swigCPtr, Vector2d.getCPtr(vec), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float hitTest(Point2d pt, float tol, MgHitResult res) {
    float ret = touchvgPINVOKE.MgRect_hitTest(swigCPtr, Point2d.getCPtr(pt), tol, MgHitResult.getCPtr(res));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
