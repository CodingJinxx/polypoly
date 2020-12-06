//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class SkewTransform : Transform {
  internal new static SkewTransform CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new SkewTransform(cPtr, cMemoryOwn);
  }

  internal SkewTransform(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(SkewTransform obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public SkewTransform() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_SkewTransform__SWIG_0();
  }

  public SkewTransform(float angleX, float angleY) : this(NoesisGUI_PINVOKE.new_SkewTransform__SWIG_1(angleX, angleY), true) {
  }

  public static DependencyProperty AngleXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SkewTransform_AngleXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty AngleYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SkewTransform_AngleYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CenterXProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SkewTransform_CenterXProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CenterYProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SkewTransform_CenterYProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float AngleX {
    set {
      NoesisGUI_PINVOKE.SkewTransform_AngleX_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.SkewTransform_AngleX_get(swigCPtr);
      return ret;
    } 
  }

  public float AngleY {
    set {
      NoesisGUI_PINVOKE.SkewTransform_AngleY_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.SkewTransform_AngleY_get(swigCPtr);
      return ret;
    } 
  }

  public float CenterX {
    set {
      NoesisGUI_PINVOKE.SkewTransform_CenterX_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.SkewTransform_CenterX_get(swigCPtr);
      return ret;
    } 
  }

  public float CenterY {
    set {
      NoesisGUI_PINVOKE.SkewTransform_CenterY_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.SkewTransform_CenterY_get(swigCPtr);
      return ret;
    } 
  }

}

}

