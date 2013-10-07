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

public class MgCommandDraw : MgCommand {
  private HandleRef swigCPtr;

  internal MgCommandDraw(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgCommandDraw_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCommandDraw obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCommandDraw() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCommandDraw(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgCommandDraw() : this(touchvgPINVOKE.new_MgCommandDraw(), true) {
    SwigDirectorConnect();
  }

  public MgShape addShape(MgMotion sender, MgShape shape, bool autolock) {
    IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_addShape__SWIG_0(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(shape), autolock);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape addShape(MgMotion sender, MgShape shape) {
    IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_addShape__SWIG_1(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(shape));
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape addShape(MgMotion sender) {
    IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_addShape__SWIG_2(swigCPtr, MgMotion.getCPtr(sender));
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public void delayClear() {
    touchvgPINVOKE.MgCommandDraw_delayClear(swigCPtr);
  }

  public bool touchBeganStep(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCommandDraw_touchBeganStep(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public bool touchMovedStep(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCommandDraw_touchMovedStep(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public bool touchEndedStep(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCommandDraw_touchEndedStep(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  protected virtual MgShape createShape(MgShapeFactory arg0) {
    IntPtr cPtr = (SwigDerivedClassHasMethod("createShape", swigMethodTypes18) ? touchvgPINVOKE.MgCommandDraw_createShapeSwigExplicitMgCommandDraw(swigCPtr, MgShapeFactory.getCPtr(arg0)) : touchvgPINVOKE.MgCommandDraw_createShape(swigCPtr, MgShapeFactory.getCPtr(arg0)));
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  protected virtual int getMaxStep() {
    int ret = (SwigDerivedClassHasMethod("getMaxStep", swigMethodTypes19) ? touchvgPINVOKE.MgCommandDraw_getMaxStepSwigExplicitMgCommandDraw(swigCPtr) : touchvgPINVOKE.MgCommandDraw_getMaxStep(swigCPtr));
    return ret;
  }

  protected virtual void setStepPoint(int step, Point2d pt) {
    if (SwigDerivedClassHasMethod("setStepPoint", swigMethodTypes20)) touchvgPINVOKE.MgCommandDraw_setStepPointSwigExplicitMgCommandDraw(swigCPtr, step, Point2d.getCPtr(pt)); else touchvgPINVOKE.MgCommandDraw_setStepPoint(swigCPtr, step, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool initialize(MgMotion sender, MgStorage arg1) {
    bool ret = (SwigDerivedClassHasMethod("initialize", swigMethodTypes3) ? touchvgPINVOKE.MgCommandDraw_initializeSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(arg1)) : touchvgPINVOKE.MgCommandDraw_initialize(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(arg1)));
    return ret;
  }

  public override bool backStep(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("backStep", swigMethodTypes4) ? touchvgPINVOKE.MgCommandDraw_backStepSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_backStep(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool cancel(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("cancel", swigMethodTypes2) ? touchvgPINVOKE.MgCommandDraw_cancelSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_cancel(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool draw(MgMotion sender, GiGraphics gs) {
    bool ret = (SwigDerivedClassHasMethod("draw", swigMethodTypes5) ? touchvgPINVOKE.MgCommandDraw_drawSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs)) : touchvgPINVOKE.MgCommandDraw_draw(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs)));
    return ret;
  }

  public override int gatherShapes(MgMotion sender, MgShapes shapes) {
    int ret = (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes6) ? touchvgPINVOKE.MgCommandDraw_gatherShapesSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), MgShapes.getCPtr(shapes)) : touchvgPINVOKE.MgCommandDraw_gatherShapes(swigCPtr, MgMotion.getCPtr(sender), MgShapes.getCPtr(shapes)));
    return ret;
  }

  public override bool touchBegan(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes10) ? touchvgPINVOKE.MgCommandDraw_touchBeganSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_touchBegan(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchMoved(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes11) ? touchvgPINVOKE.MgCommandDraw_touchMovedSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_touchMoved(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchEnded(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes12) ? touchvgPINVOKE.MgCommandDraw_touchEndedSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_touchEnded(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool click(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("click", swigMethodTypes7) ? touchvgPINVOKE.MgCommandDraw_clickSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_click(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool longPress(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("longPress", swigMethodTypes9) ? touchvgPINVOKE.MgCommandDraw_longPressSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_longPress(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool mouseHover(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes13) ? touchvgPINVOKE.MgCommandDraw_mouseHoverSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_mouseHover(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public int getStep() {
    int ret = touchvgPINVOKE.MgCommandDraw_getStep(swigCPtr);
    return ret;
  }

  public MgShape dynshape() {
    IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_dynshape(swigCPtr);
    MgShape ret = (cPtr == IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public Point2d snapPoint(MgMotion sender, bool firstStep) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_0(swigCPtr, MgMotion.getCPtr(sender), firstStep), true);
    return ret;
  }

  public Point2d snapPoint(MgMotion sender) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_1(swigCPtr, MgMotion.getCPtr(sender)), true);
    return ret;
  }

  public Point2d snapPoint(MgMotion sender, Point2d orignPt, bool firstStep) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_2(swigCPtr, MgMotion.getCPtr(sender), Point2d.getCPtr(orignPt), firstStep), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d snapPoint(MgMotion sender, Point2d orignPt) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_3(swigCPtr, MgMotion.getCPtr(sender), Point2d.getCPtr(orignPt)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("getName", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgCommandDraw_0(SwigDirectorgetName);
    if (SwigDerivedClassHasMethod("release", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgCommandDraw_1(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("cancel", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgCommandDraw_2(SwigDirectorcancel);
    if (SwigDerivedClassHasMethod("initialize", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgCommandDraw_3(SwigDirectorinitialize);
    if (SwigDerivedClassHasMethod("backStep", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgCommandDraw_4(SwigDirectorbackStep);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgCommandDraw_5(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgCommandDraw_6(SwigDirectorgatherShapes);
    if (SwigDerivedClassHasMethod("click", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgCommandDraw_7(SwigDirectorclick);
    if (SwigDerivedClassHasMethod("doubleClick", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgCommandDraw_8(SwigDirectordoubleClick);
    if (SwigDerivedClassHasMethod("longPress", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgCommandDraw_9(SwigDirectorlongPress);
    if (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgCommandDraw_10(SwigDirectortouchBegan);
    if (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgCommandDraw_11(SwigDirectortouchMoved);
    if (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgCommandDraw_12(SwigDirectortouchEnded);
    if (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgCommandDraw_13(SwigDirectormouseHover);
    if (SwigDerivedClassHasMethod("twoFingersMove", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgCommandDraw_14(SwigDirectortwoFingersMove);
    if (SwigDerivedClassHasMethod("isDrawingCommand", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgCommandDraw_15(SwigDirectorisDrawingCommand);
    if (SwigDerivedClassHasMethod("isFloatingCommand", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgCommandDraw_16(SwigDirectorisFloatingCommand);
    if (SwigDerivedClassHasMethod("doContextAction", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgCommandDraw_17(SwigDirectordoContextAction);
    if (SwigDerivedClassHasMethod("createShape", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgCommandDraw_18(SwigDirectorcreateShape);
    if (SwigDerivedClassHasMethod("getMaxStep", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgCommandDraw_19(SwigDirectorgetMaxStep);
    if (SwigDerivedClassHasMethod("setStepPoint", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateMgCommandDraw_20(SwigDirectorsetStepPoint);
    touchvgPINVOKE.MgCommandDraw_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgCommandDraw));
    return hasDerivedMethod;
  }

  private string SwigDirectorgetName() {
    return getName();
  }

  private void SwigDirectorrelease() {
    release();
  }

  private bool SwigDirectorcancel(IntPtr sender) {
    return cancel((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorinitialize(IntPtr sender, IntPtr arg1) {
    return initialize((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), (arg1 == IntPtr.Zero) ? null : new MgStorage(arg1, false));
  }

  private bool SwigDirectorbackStep(IntPtr sender) {
    return backStep((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordraw(IntPtr sender, IntPtr gs) {
    return draw((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), (gs == IntPtr.Zero) ? null : new GiGraphics(gs, false));
  }

  private int SwigDirectorgatherShapes(IntPtr sender, IntPtr shapes) {
    return gatherShapes((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), (shapes == IntPtr.Zero) ? null : new MgShapes(shapes, false));
  }

  private bool SwigDirectorclick(IntPtr sender) {
    return click((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordoubleClick(IntPtr sender) {
    return doubleClick((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorlongPress(IntPtr sender) {
    return longPress((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchBegan(IntPtr sender) {
    return touchBegan((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchMoved(IntPtr sender) {
    return touchMoved((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchEnded(IntPtr sender) {
    return touchEnded((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectormouseHover(IntPtr sender) {
    return mouseHover((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortwoFingersMove(IntPtr sender) {
    return twoFingersMove((sender == IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorisDrawingCommand() {
    return isDrawingCommand();
  }

  private bool SwigDirectorisFloatingCommand() {
    return isFloatingCommand();
  }

  private bool SwigDirectordoContextAction(IntPtr sender, int action) {
    return doContextAction((sender == IntPtr.Zero) ? null : new MgMotion(sender, false), action);
  }

  private IntPtr SwigDirectorcreateShape(IntPtr arg0) {
    return MgShape.getCPtr(createShape((arg0 == IntPtr.Zero) ? null : new MgShapeFactory(arg0, false))).Handle;
  }

  private int SwigDirectorgetMaxStep() {
    return getMaxStep();
  }

  private void SwigDirectorsetStepPoint(int step, IntPtr pt) {
    setStepPoint(step, new Point2d(pt, false));
  }

  public delegate string SwigDelegateMgCommandDraw_0();
  public delegate void SwigDelegateMgCommandDraw_1();
  public delegate bool SwigDelegateMgCommandDraw_2(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_3(IntPtr sender, IntPtr arg1);
  public delegate bool SwigDelegateMgCommandDraw_4(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_5(IntPtr sender, IntPtr gs);
  public delegate int SwigDelegateMgCommandDraw_6(IntPtr sender, IntPtr shapes);
  public delegate bool SwigDelegateMgCommandDraw_7(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_8(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_9(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_10(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_11(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_12(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_13(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_14(IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_15();
  public delegate bool SwigDelegateMgCommandDraw_16();
  public delegate bool SwigDelegateMgCommandDraw_17(IntPtr sender, int action);
  public delegate IntPtr SwigDelegateMgCommandDraw_18(IntPtr arg0);
  public delegate int SwigDelegateMgCommandDraw_19();
  public delegate void SwigDelegateMgCommandDraw_20(int step, IntPtr pt);

  private SwigDelegateMgCommandDraw_0 swigDelegate0;
  private SwigDelegateMgCommandDraw_1 swigDelegate1;
  private SwigDelegateMgCommandDraw_2 swigDelegate2;
  private SwigDelegateMgCommandDraw_3 swigDelegate3;
  private SwigDelegateMgCommandDraw_4 swigDelegate4;
  private SwigDelegateMgCommandDraw_5 swigDelegate5;
  private SwigDelegateMgCommandDraw_6 swigDelegate6;
  private SwigDelegateMgCommandDraw_7 swigDelegate7;
  private SwigDelegateMgCommandDraw_8 swigDelegate8;
  private SwigDelegateMgCommandDraw_9 swigDelegate9;
  private SwigDelegateMgCommandDraw_10 swigDelegate10;
  private SwigDelegateMgCommandDraw_11 swigDelegate11;
  private SwigDelegateMgCommandDraw_12 swigDelegate12;
  private SwigDelegateMgCommandDraw_13 swigDelegate13;
  private SwigDelegateMgCommandDraw_14 swigDelegate14;
  private SwigDelegateMgCommandDraw_15 swigDelegate15;
  private SwigDelegateMgCommandDraw_16 swigDelegate16;
  private SwigDelegateMgCommandDraw_17 swigDelegate17;
  private SwigDelegateMgCommandDraw_18 swigDelegate18;
  private SwigDelegateMgCommandDraw_19 swigDelegate19;
  private SwigDelegateMgCommandDraw_20 swigDelegate20;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(MgMotion), typeof(MgStorage) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(MgMotion), typeof(GiGraphics) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(MgMotion), typeof(MgShapes) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes14 = new Type[] { typeof(MgMotion) };
  private static Type[] swigMethodTypes15 = new Type[] {  };
  private static Type[] swigMethodTypes16 = new Type[] {  };
  private static Type[] swigMethodTypes17 = new Type[] { typeof(MgMotion), typeof(int) };
  private static Type[] swigMethodTypes18 = new Type[] { typeof(MgShapeFactory) };
  private static Type[] swigMethodTypes19 = new Type[] {  };
  private static Type[] swigMethodTypes20 = new Type[] { typeof(int), typeof(Point2d) };
}

}
