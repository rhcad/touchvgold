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

public class MgView : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgView(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgView obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgView() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgView(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual MgCmdManager cmds() {
    IntPtr cPtr = touchvgPINVOKE.MgView_cmds(swigCPtr);
    MgCmdManager ret = (cPtr == IntPtr.Zero) ? null : new MgCmdManager(cPtr, false);
    return ret;
  }

  public virtual GiTransform xform() {
    IntPtr cPtr = touchvgPINVOKE.MgView_xform(swigCPtr);
    GiTransform ret = (cPtr == IntPtr.Zero) ? null : new GiTransform(cPtr, false);
    return ret;
  }

  public virtual GiGraphics graph() {
    IntPtr cPtr = touchvgPINVOKE.MgView_graph(swigCPtr);
    GiGraphics ret = (cPtr == IntPtr.Zero) ? null : new GiGraphics(cPtr, false);
    return ret;
  }

  public virtual MgShapeDoc doc() {
    IntPtr cPtr = touchvgPINVOKE.MgView_doc(swigCPtr);
    MgShapeDoc ret = (cPtr == IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public virtual MgShapes shapes() {
    IntPtr cPtr = touchvgPINVOKE.MgView_shapes(swigCPtr);
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public virtual GiContext context() {
    IntPtr cPtr = touchvgPINVOKE.MgView_context(swigCPtr);
    GiContext ret = (cPtr == IntPtr.Zero) ? null : new GiContext(cPtr, false);
    return ret;
  }

  public virtual Matrix2d modelTransform() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.MgView_modelTransform(swigCPtr), false);
    return ret;
  }

  public virtual MgShapeFactory getShapeFactory() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getShapeFactory(swigCPtr);
    MgShapeFactory ret = (cPtr == IntPtr.Zero) ? null : new MgShapeFactory(cPtr, false);
    return ret;
  }

  public virtual MgSnap getSnap() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getSnap(swigCPtr);
    MgSnap ret = (cPtr == IntPtr.Zero) ? null : new MgSnap(cPtr, false);
    return ret;
  }

  public virtual MgActionDispatcher getAction() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getAction(swigCPtr);
    MgActionDispatcher ret = (cPtr == IntPtr.Zero) ? null : new MgActionDispatcher(cPtr, false);
    return ret;
  }

  public virtual MgLockData getLockData() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getLockData(swigCPtr);
    MgLockData ret = (cPtr == IntPtr.Zero) ? null : new MgLockData(cPtr, false);
    return ret;
  }

  public virtual CmdSubject getCmdSubject() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getCmdSubject(swigCPtr);
    CmdSubject ret = (cPtr == IntPtr.Zero) ? null : new CmdSubject(cPtr, false);
    return ret;
  }

  public virtual MgSelection getSelection() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getSelection(swigCPtr);
    MgSelection ret = (cPtr == IntPtr.Zero) ? null : new MgSelection(cPtr, false);
    return ret;
  }

  public virtual bool setCurrentShapes(MgShapes shapes) {
    bool ret = touchvgPINVOKE.MgView_setCurrentShapes(swigCPtr, MgShapes.getCPtr(shapes));
    return ret;
  }

  public virtual void cancel(MgMotion sender) {
    touchvgPINVOKE.MgView_cancel(swigCPtr, MgMotion.getCPtr(sender));
  }

  public virtual int getNewShapeID() {
    int ret = touchvgPINVOKE.MgView_getNewShapeID(swigCPtr);
    return ret;
  }

  public virtual void setNewShapeID(int sid) {
    touchvgPINVOKE.MgView_setNewShapeID(swigCPtr, sid);
  }

  public virtual MgCommand getCommand() {
    IntPtr cPtr = touchvgPINVOKE.MgView_getCommand(swigCPtr);
    MgCommand ret = (cPtr == IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

  public virtual MgCommand findCommand(string name) {
    IntPtr cPtr = touchvgPINVOKE.MgView_findCommand(swigCPtr, name);
    MgCommand ret = (cPtr == IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

  public virtual bool setCommand(MgMotion sender, string name) {
    bool ret = touchvgPINVOKE.MgView_setCommand(swigCPtr, MgMotion.getCPtr(sender), name);
    return ret;
  }

  public virtual void regenAll() {
    touchvgPINVOKE.MgView_regenAll(swigCPtr);
  }

  public virtual void regenAppend() {
    touchvgPINVOKE.MgView_regenAppend(swigCPtr);
  }

  public virtual void redraw() {
    touchvgPINVOKE.MgView_redraw(swigCPtr);
  }

  public virtual bool useFinger() {
    bool ret = touchvgPINVOKE.MgView_useFinger(swigCPtr);
    return ret;
  }

  public virtual void commandChanged() {
    touchvgPINVOKE.MgView_commandChanged(swigCPtr);
  }

  public virtual void selectionChanged() {
    touchvgPINVOKE.MgView_selectionChanged(swigCPtr);
  }

  public virtual bool shapeWillAdded(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_shapeWillAdded(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual void shapeAdded(MgShape shape) {
    touchvgPINVOKE.MgView_shapeAdded(swigCPtr, MgShape.getCPtr(shape));
  }

  public virtual bool shapeWillDeleted(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_shapeWillDeleted(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual bool removeShape(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_removeShape(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual bool shapeCanRotated(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_shapeCanRotated(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual bool shapeCanTransform(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_shapeCanTransform(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual bool shapeCanUnlock(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_shapeCanUnlock(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual bool shapeCanUngroup(MgShape shape) {
    bool ret = touchvgPINVOKE.MgView_shapeCanUngroup(swigCPtr, MgShape.getCPtr(shape));
    return ret;
  }

  public virtual void shapeMoved(MgShape shape, int segment) {
    touchvgPINVOKE.MgView_shapeMoved(swigCPtr, MgShape.getCPtr(shape), segment);
  }

  public virtual bool isContextActionsVisible() {
    bool ret = touchvgPINVOKE.MgView_isContextActionsVisible(swigCPtr);
    return ret;
  }

}

}
