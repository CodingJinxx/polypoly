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

public class ToolBarTray : FrameworkElement {
  internal new static ToolBarTray CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ToolBarTray(cPtr, cMemoryOwn);
  }

  internal ToolBarTray(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ToolBarTray obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ToolBarTray() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(ToolBarTray)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ToolBarTray();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static bool GetIsLocked(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      bool ret = NoesisGUI_PINVOKE.ToolBarTray_GetIsLocked(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetIsLocked(DependencyObject element, bool isLocked) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.ToolBarTray_SetIsLocked(DependencyObject.getCPtr(element), isLocked);
    }
  }

  public static DependencyProperty BackgroundProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBarTray_BackgroundProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsLockedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBarTray_IsLockedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OrientationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBarTray_OrientationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Brush Background {
    set {
      NoesisGUI_PINVOKE.ToolBarTray_Background_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBarTray_Background_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Orientation Orientation {
    set {
      NoesisGUI_PINVOKE.ToolBarTray_Orientation_set(swigCPtr, (int)value);
    } 
    get {
      Orientation ret = (Orientation)NoesisGUI_PINVOKE.ToolBarTray_Orientation_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ToolBarTray(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

