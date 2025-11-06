using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;
using GameInputNet.Interop.Interfaces;

namespace GameInputNet.Interop.Delegates;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public unsafe delegate void GameInputSystemButtonCallback(ulong callbackToken, void* context,
    [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp,
    GameInputSystemButtons currentButtons, GameInputSystemButtons previousButtons);
