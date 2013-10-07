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

public class CmdObserver : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CmdObserver(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CmdObserver obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CmdObserver() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_CmdObserver(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void onDocLoaded(MgMotion sender) {
    touchvgPINVOKE.CmdObserver_onDocLoaded(swigCPtr, MgMotion.getCPtr(sender));
  }

  public virtual void onEnterSelectCommand(MgMotion sender) {
    touchvgPINVOKE.CmdObserver_onEnterSelectCommand(swigCPtr, MgMotion.getCPtr(sender));
  }

  public virtual void onUnloadCommands(MgCmdManager sender) {
    touchvgPINVOKE.CmdObserver_onUnloadCommands(swigCPtr, MgCmdManager.getCPtr(sender));
  }

  public virtual bool selectActionsNeedHided(MgMotion sender) {
    bool ret = touchvgPINVOKE.CmdObserver_selectActionsNeedHided(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public virtual bool doAction(MgMotion sender, int action) {
    bool ret = touchvgPINVOKE.CmdObserver_doAction(swigCPtr, MgMotion.getCPtr(sender), action);
    return ret;
  }

  public virtual bool doEndAction(MgMotion sender, int action) {
    bool ret = touchvgPINVOKE.CmdObserver_doEndAction(swigCPtr, MgMotion.getCPtr(sender), action);
    return ret;
  }

  public virtual void drawInShapeCommand(MgMotion sender, MgCommand cmd, GiGraphics gs) {
    touchvgPINVOKE.CmdObserver_drawInShapeCommand(swigCPtr, MgMotion.getCPtr(sender), MgCommand.getCPtr(cmd), GiGraphics.getCPtr(gs));
  }

  public virtual void drawInSelectCommand(MgMotion sender, MgShape sp, int handleIndex, GiGraphics gs) {
    touchvgPINVOKE.CmdObserver_drawInSelectCommand(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), handleIndex, GiGraphics.getCPtr(gs));
  }

  public virtual bool onShapeWillAdded(MgMotion sender, MgShape sp) {
    bool ret = touchvgPINVOKE.CmdObserver_onShapeWillAdded(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
    return ret;
  }

  public virtual void onShapeAdded(MgMotion sender, MgShape sp) {
    touchvgPINVOKE.CmdObserver_onShapeAdded(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
  }

  public virtual bool onShapeWillDeleted(MgMotion sender, MgShape sp) {
    bool ret = touchvgPINVOKE.CmdObserver_onShapeWillDeleted(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
    return ret;
  }

  public virtual void onShapeDeleted(MgMotion sender, MgShape sp) {
    touchvgPINVOKE.CmdObserver_onShapeDeleted(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
  }

  public virtual bool onShapeCanRotated(MgMotion sender, MgShape sp) {
    bool ret = touchvgPINVOKE.CmdObserver_onShapeCanRotated(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
    return ret;
  }

  public virtual bool onShapeCanTransform(MgMotion sender, MgShape sp) {
    bool ret = touchvgPINVOKE.CmdObserver_onShapeCanTransform(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
    return ret;
  }

  public virtual bool onShapeCanUnlock(MgMotion sender, MgShape sp) {
    bool ret = touchvgPINVOKE.CmdObserver_onShapeCanUnlock(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
    return ret;
  }

  public virtual bool onShapeCanUngroup(MgMotion sender, MgShape sp) {
    bool ret = touchvgPINVOKE.CmdObserver_onShapeCanUngroup(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp));
    return ret;
  }

  public virtual void onShapeMoved(MgMotion sender, MgShape sp, int segment) {
    touchvgPINVOKE.CmdObserver_onShapeMoved(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(sp), segment);
  }

  public virtual MgBaseShape createShape(MgMotion sender, int type) {
    IntPtr cPtr = touchvgPINVOKE.CmdObserver_createShape(swigCPtr, MgMotion.getCPtr(sender), type);
    MgBaseShape ret = (cPtr == IntPtr.Zero) ? null : new MgBaseShape(cPtr, false);
    return ret;
  }

  public virtual MgCommand createCommand(MgMotion sender, string name) {
    IntPtr cPtr = touchvgPINVOKE.CmdObserver_createCommand(swigCPtr, MgMotion.getCPtr(sender), name);
    MgCommand ret = (cPtr == IntPtr.Zero) ? null : new MgCommand(cPtr, false);
    return ret;
  }

}

}