using System;
using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Interfaces;

[ComImport]
[Guid("415EED2E-98CB-42C2-8F28-B94601074E31")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInputDispatcher
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    bool Dispatch(ulong quotaInMicroseconds);

    [PreserveSig]
    int OpenWaitHandle(out IntPtr waitHandle);
}
