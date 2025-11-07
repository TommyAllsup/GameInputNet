using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Interfaces;

namespace GameInputDotNet.Interop.Delegates;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public unsafe delegate void GameInputKeyboardLayoutCallback(ulong callbackToken, void* context,
    [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp, uint currentLayout,
    uint previousLayout);