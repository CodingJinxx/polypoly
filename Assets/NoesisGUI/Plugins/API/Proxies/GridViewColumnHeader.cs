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

public class GridViewColumnHeader : ButtonBase {
  internal new static GridViewColumnHeader CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GridViewColumnHeader(cPtr, cMemoryOwn);
  }

  internal GridViewColumnHeader(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GridViewColumnHeader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public GridViewColumnHeader() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_GridViewColumnHeader();
  }

  public static DependencyProperty RoleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumnHeader_RoleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public GridViewColumn Column {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GridViewColumnHeader_Column_get(swigCPtr);
      return (GridViewColumn)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public GridViewColumnHeaderRole Role {
    get {
      GridViewColumnHeaderRole ret = (GridViewColumnHeaderRole)NoesisGUI_PINVOKE.GridViewColumnHeader_Role_get(swigCPtr);
      return ret;
    } 
  }

}

}

