using System.Runtime.InteropServices;
using GameInputNet.Interop.Interfaces;

namespace GameInputNet.Interop.Delegates;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public unsafe delegate void GameInputReadingCallback(ulong callbackToken, void* context,
    [MarshalAs(UnmanagedType.Interface)] IGameInputReading reading);
