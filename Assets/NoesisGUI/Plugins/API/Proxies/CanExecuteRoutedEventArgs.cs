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
using System.Windows.Input;

namespace Noesis
{

public class CanExecuteRoutedEventArgs : RoutedEventArgs {
  private HandleRef swigCPtr;

  internal CanExecuteRoutedEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CanExecuteRoutedEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CanExecuteRoutedEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_CanExecuteRoutedEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    CanExecuteRoutedEventHandler handler_ = (CanExecuteRoutedEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new CanExecuteRoutedEventArgs(args, false));
    }
  }

  public ICommand Command {
    get {
      return GetCommandHelper() as ICommand;
    }
  }

  public object Parameter {
    get {
      return GetParameterHelper();
    }
  }

  public bool CanExecute {
    set {
      NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_CanExecute_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_CanExecute_get(swigCPtr);
      return ret;
    } 
  }

  public bool ContinueRouting {
    set {
      NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_ContinueRouting_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_ContinueRouting_get(swigCPtr);
      return ret;
    } 
  }

  private object GetCommandHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_GetCommandHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  private object GetParameterHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_GetParameterHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

}

}

