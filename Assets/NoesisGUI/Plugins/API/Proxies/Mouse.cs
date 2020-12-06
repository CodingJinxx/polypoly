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

public class Mouse : BaseComponent {
  internal new static Mouse CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Mouse(cPtr, cMemoryOwn);
  }

  internal Mouse(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Mouse obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Mouse() {
  }

  public Point Position {
    get {
      Point pos;
      GetPositionHelper(out pos);
      return pos;
    }
  }

  public static Point GetPosition(UIElement relativeTo) {
    IntPtr ret = NoesisGUI_PINVOKE.Mouse_GetPosition(UIElement.getCPtr(relativeTo));
    if (ret != IntPtr.Zero) {
      return Marshal.PtrToStructure<Point>(ret);
    }
    else {
      return new Point();
    }
  }

  public MouseButtonState GetButtonState(MouseButton button) {
    MouseButtonState ret = (MouseButtonState)NoesisGUI_PINVOKE.Mouse_GetButtonState(swigCPtr, (int)button);
    return ret;
  }

  public bool Capture(UIElement element, CaptureMode mode) {
    bool ret = NoesisGUI_PINVOKE.Mouse_Capture__SWIG_0(swigCPtr, UIElement.getCPtr(element), (int)mode);
    return ret;
  }

  public bool Capture(UIElement element) {
    bool ret = NoesisGUI_PINVOKE.Mouse_Capture__SWIG_1(swigCPtr, UIElement.getCPtr(element));
    return ret;
  }

  public static RoutedEvent GotMouseCaptureEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_GotMouseCaptureEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent LostMouseCaptureEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_LostMouseCaptureEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent MouseDownEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_MouseDownEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent MouseEnterEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_MouseEnterEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent MouseLeaveEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_MouseLeaveEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent MouseMoveEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_MouseMoveEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent MouseUpEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_MouseUpEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent MouseWheelEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_MouseWheelEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewMouseDownEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_PreviewMouseDownEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewMouseMoveEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_PreviewMouseMoveEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewMouseUpEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_PreviewMouseUpEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent PreviewMouseWheelEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_PreviewMouseWheelEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static RoutedEvent QueryCursorEvent {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_QueryCursorEvent_get();
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public UIElement Captured {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Mouse_Captured_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  private void GetPositionHelper(out Point pos) {
    NoesisGUI_PINVOKE.Mouse_GetPositionHelper(swigCPtr, out pos);
  }

}

}

