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

public class MgCmdManager : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgCmdManager(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCmdManager obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCmdManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCmdManager(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void release() {
    touchvgPINVOKE.MgCmdManager_release(swigCPtr);
  }

  public virtual string getCommandName() {
    string ret = touchvgPINVOKE.MgCmdManager_getCommandName(swigCPtr);
    return ret;
  }

  public virtual MgCommand getCommand() {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_getCommand(swigCPtr);
    MgCommand ret = (cPtr == IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

  public virtual MgCommand findCommand(string name) {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_findCommand(swigCPtr, name);
    MgCommand ret = (cPtr == IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

  public virtual bool setCommand(MgMotion sender, string name, MgStorage s) {
    bool ret = touchvgPINVOKE.MgCmdManager_setCommand(swigCPtr, MgMotion.getCPtr(sender), name, MgStorage.getCPtr(s));
    return ret;
  }

  public virtual bool cancel(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCmdManager_cancel(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public virtual void unloadCommands() {
    touchvgPINVOKE.MgCmdManager_unloadCommands(swigCPtr);
  }

  public virtual int getNewShapeID() {
    int ret = touchvgPINVOKE.MgCmdManager_getNewShapeID(swigCPtr);
    return ret;
  }

  public virtual void setNewShapeID(int sid) {
    touchvgPINVOKE.MgCmdManager_setNewShapeID(swigCPtr, sid);
  }

  public virtual float displayMmToModel(float mm, GiGraphics gs) {
    float ret = touchvgPINVOKE.MgCmdManager_displayMmToModel__SWIG_0(swigCPtr, mm, GiGraphics.getCPtr(gs));
    return ret;
  }

  public virtual float displayMmToModel(float mm, MgMotion sender) {
    float ret = touchvgPINVOKE.MgCmdManager_displayMmToModel__SWIG_1(swigCPtr, mm, MgMotion.getCPtr(sender));
    return ret;
  }

  public virtual bool dynamicChangeEnded(MgView view, bool apply) {
    bool ret = touchvgPINVOKE.MgCmdManager_dynamicChangeEnded(swigCPtr, MgView.getCPtr(view), apply);
    return ret;
  }

  public virtual MgSelection getSelection() {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_getSelection(swigCPtr);
    MgSelection ret = (cPtr == IntPtr.Zero) ? null : new MgSelection(cPtr, false);
    return ret;
  }

  public virtual MgActionDispatcher getActionDispatcher() {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_getActionDispatcher(swigCPtr);
    MgActionDispatcher ret = (cPtr == IntPtr.Zero) ? null : new MgActionDispatcher(cPtr, false);
    return ret;
  }

  public virtual bool doContextAction(MgMotion sender, int action) {
    bool ret = touchvgPINVOKE.MgCmdManager_doContextAction(swigCPtr, MgMotion.getCPtr(sender), action);
    return ret;
  }

  public virtual MgSnap getSnap() {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_getSnap(swigCPtr);
    MgSnap ret = (cPtr == IntPtr.Zero) ? null : new MgSnap(cPtr, false);
    return ret;
  }

  public virtual CmdSubject getCmdSubject() {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_getCmdSubject(swigCPtr);
    CmdSubject ret = (cPtr == IntPtr.Zero) ? null : new CmdSubject(cPtr, false);
    return ret;
  }

  public virtual MgShape addImageShape(MgMotion sender, string name, float width, float height) {
    IntPtr cPtr = touchvgPINVOKE.MgCmdManager_addImageShape(swigCPtr, MgMotion.getCPtr(sender), name, width, height);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public virtual void getBoundingBox(Box2d box, MgMotion sender) {
    touchvgPINVOKE.MgCmdManager_getBoundingBox(swigCPtr, Box2d.getCPtr(box), MgMotion.getCPtr(sender));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
