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

internal class ExtendListIndexer : BaseComponent {
  internal new static ExtendListIndexer CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ExtendListIndexer(cPtr, cMemoryOwn);
  }

  internal ExtendListIndexer(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ExtendListIndexer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ExtendListIndexer() {
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ExtendListIndexer(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

