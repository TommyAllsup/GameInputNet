using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Interfaces;

namespace GameInputDotNet.Interop.Delegates;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public unsafe delegate void GameInputReadingCallback(ulong callbackToken, void* context,
    [MarshalAs(UnmanagedType.Interface)] IGameInputReading reading);