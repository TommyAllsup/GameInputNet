using System.Runtime.InteropServices;
using GameInputNet.Interop.Delegates;
using GameInputNet.Interop.Enums;
using GameInputNet.Interop.Structs;

namespace GameInputNet.Interop.Interfaces;

[ComImport]
[Guid("20EFC1C7-5D9A-43BA-B26F-B807FA48609C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInput
{
    [PreserveSig]
    ulong GetCurrentTimestamp();

    [PreserveSig]
    int GetCurrentReading(GameInputKind inputKind, [MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
        out IGameInputReading? reading);

    [PreserveSig]
    int GetNextReading([MarshalAs(UnmanagedType.Interface)] IGameInputReading referenceReading,
        GameInputKind inputKind,
        [MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device, out IGameInputReading? reading);

    [PreserveSig]
    int GetPreviousReading([MarshalAs(UnmanagedType.Interface)] IGameInputReading referenceReading, GameInputKind
        inputKind, [MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device, out IGameInputReading? reading);

    [PreserveSig]
    unsafe int RegisterReadingCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
        GameInputKind inputKind,
        void* context, GameInputReadingCallback callback, out ulong callbackToken);

    [PreserveSig]
    unsafe int RegisterDeviceCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
        GameInputKind inputKind, uint statusFilter, GameInputEnumerationKind enumerationKind, void* context,
        GameInputDeviceCallback callback, out ulong callbackToken);

    [PreserveSig]
    unsafe int RegisterSystemButtonCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
        GameInputSystemButtons buttonFilter, void* context, GameInputSystemButtonCallback callback,
        out ulong callbackToken);

    [PreserveSig]
    unsafe int RegisterKeyboardLayoutCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
        void* context, GameInputKeyboardLayoutCallback callback, out ulong callbackToken);

    [PreserveSig]
    void StopCallback(ulong callbackToken);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    bool UnregisterCallback(ulong callbackToken);

    [PreserveSig]
    int CreateDispatcher(out IGameInputDispatcher? dispatcher);

    [PreserveSig]
    unsafe int FindDeviceFromId(AppLocalDeviceId* deviceId, out IGameInputDevice? device);

    [PreserveSig]
    int FindDeviceFromPlatformString([MarshalAs(UnmanagedType.LPWStr)] string value, out IGameInputDevice?
        device);

    [PreserveSig]
    void SetFocusPolicy(GameInputFocusPolicy policy);

    [PreserveSig]
    unsafe int CreateAggregateDevice(GameInputKind inputKind, AppLocalDeviceId* deviceId);

    [PreserveSig]
    unsafe int DisableAggregateDevice(AppLocalDeviceId* deviceId);
}
