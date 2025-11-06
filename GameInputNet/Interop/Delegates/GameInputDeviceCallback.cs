using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;
using GameInputNet.Interop.Interfaces;

namespace GameInputNet.Interop.Delegates;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
public unsafe delegate void GameInputDeviceCallback(ulong callbackToken, void* context,
    [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp,
    GameInputDeviceStatus currentStatus, GameInputDeviceStatus previousStatus);
