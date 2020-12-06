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

public class ImageBrush : TileBrush {
  internal new static ImageBrush CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ImageBrush(cPtr, cMemoryOwn);
  }

  internal ImageBrush(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ImageBrush obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ImageBrush() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_ImageBrush__SWIG_0();
  }

  public ImageBrush(ImageSource imageSource) : this(NoesisGUI_PINVOKE.new_ImageBrush__SWIG_1(ImageSource.getCPtr(imageSource)), true) {
  }

  public static DependencyProperty ImageSourceProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ImageBrush_ImageSourceProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ImageSource ImageSource {
    set {
      NoesisGUI_PINVOKE.ImageBrush_ImageSource_set(swigCPtr, ImageSource.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ImageBrush_ImageSource_get(swigCPtr);
      return (ImageSource)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

