/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.jni;

public class MgShape extends MgObject {
  private long swigCPtr;

  protected MgShape(long cPtr, boolean cMemoryOwn) {
    super(skiaviewJNI.MgShape_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgShape obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        skiaviewJNI.delete_MgShape(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public static int Type() {
    return skiaviewJNI.MgShape_Type();
  }

  public MgShape cloneShape() {
    long cPtr = skiaviewJNI.MgShape_cloneShape(swigCPtr, this);
    return (cPtr == 0) ? null : new MgShape(cPtr, false);
  }

  public GiContext context() {
    long cPtr = skiaviewJNI.MgShape_context(swigCPtr, this);
    return (cPtr == 0) ? null : new GiContext(cPtr, false);
  }

  public GiContext contextc() {
    long cPtr = skiaviewJNI.MgShape_contextc(swigCPtr, this);
    return (cPtr == 0) ? null : new GiContext(cPtr, false);
  }

  public MgBaseShape shape() {
    long cPtr = skiaviewJNI.MgShape_shape(swigCPtr, this);
    return (cPtr == 0) ? null : new MgBaseShape(cPtr, false);
  }

  public MgBaseShape shapec() {
    long cPtr = skiaviewJNI.MgShape_shapec(swigCPtr, this);
    return (cPtr == 0) ? null : new MgBaseShape(cPtr, false);
  }

  public boolean draw(int mode, GiGraphics gs, GiContext ctx) {
    return skiaviewJNI.MgShape_draw__SWIG_0(swigCPtr, this, mode, GiGraphics.getCPtr(gs), gs, GiContext.getCPtr(ctx), ctx);
  }

  public boolean draw(int mode, GiGraphics gs) {
    return skiaviewJNI.MgShape_draw__SWIG_1(swigCPtr, this, mode, GiGraphics.getCPtr(gs), gs);
  }

  public boolean save(MgStorage s) {
    return skiaviewJNI.MgShape_save(swigCPtr, this, MgStorage.getCPtr(s), s);
  }

  public boolean load(MgStorage s) {
    return skiaviewJNI.MgShape_load(swigCPtr, this, MgStorage.getCPtr(s), s);
  }

  public int getID() {
    return skiaviewJNI.MgShape_getID(swigCPtr, this);
  }

  public MgShapes getParent() {
    long cPtr = skiaviewJNI.MgShape_getParent(swigCPtr, this);
    return (cPtr == 0) ? null : new MgShapes(cPtr, false);
  }

  public void setParent(MgShapes p, int sid) {
    skiaviewJNI.MgShape_setParent(swigCPtr, this, MgShapes.getCPtr(p), p, sid);
  }

  public int getTag() {
    return skiaviewJNI.MgShape_getTag(swigCPtr, this);
  }

  public void setTag(int tag) {
    skiaviewJNI.MgShape_setTag(swigCPtr, this, tag);
  }

}