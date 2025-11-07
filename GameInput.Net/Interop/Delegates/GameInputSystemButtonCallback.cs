using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;
using GameInputDotNet.Interop.Interfaces;

namespace GameInputDotNet.Interop.Delegates;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public unsafe delegate void GameInputSystemButtonCallback(ulong callbackToken, void* context,
    [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp,
    GameInputSystemButtons currentButtons, GameInputSystemButtons previousButtons);