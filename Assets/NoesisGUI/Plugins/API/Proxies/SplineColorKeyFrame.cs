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

public class SplineColorKeyFrame : ColorKeyFrame {
  internal new static SplineColorKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new SplineColorKeyFrame(cPtr, cMemoryOwn);
  }

  internal SplineColorKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(SplineColorKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public static DependencyProperty KeySplineProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SplineColorKeyFrame_KeySplineProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeySpline KeySpline {
    set {
      NoesisGUI_PINVOKE.SplineColorKeyFrame_KeySpline_set(swigCPtr, KeySpline.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SplineColorKeyFrame_KeySpline_get(swigCPtr);
      return (KeySpline)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public SplineColorKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_SplineColorKeyFrame();
  }

}

}

