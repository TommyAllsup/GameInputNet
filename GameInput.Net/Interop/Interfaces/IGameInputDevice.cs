using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;
using GameInputDotNet.Interop.Structs;

namespace GameInputDotNet.Interop.Interfaces;

[ComImport]
[Guid("63E2F38B-A399-4275-8AE7-D4C6E524D12A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInputDevice
{
    [PreserveSig]
    unsafe int GetDeviceInfo(out GameInputDeviceInfo* info);

    [PreserveSig]
    unsafe int GetHapticInfo(GameInputHapticInfo* info);

    [PreserveSig]
    GameInputDeviceStatus GetDeviceStatus();

    [PreserveSig]
    unsafe int CreateForceFeedbackEffect(uint motorIndex, GameInputForceFeedbackParams* @params,
        out IGameInputForceFeedbackEffect? effect);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    bool IsForceFeedbackMotorPoweredOn(uint motorIndex);

    [PreserveSig]
    void SetForceFeedbackMotorGain(uint motorIndex, float masterGain);

    [PreserveSig]
    unsafe void SetRumbleState(GameInputRumbleParams* @params);

    [PreserveSig]
    unsafe int DirectInputEscape(uint command, void* bufferIn, uint bufferInSize, void* bufferOut,
        uint bufferOutSize, uint* bufferOutSizeWritten);

    [PreserveSig]
    int CreateInputMapper(out IGameInputMapper? inputMapper);

    [PreserveSig]
    unsafe int GetExtraAxisCount(GameInputKind inputKind, uint* extraAxisCount);

    [PreserveSig]
    unsafe int GetExtraButtonCount(GameInputKind inputKind, uint* extraButtonCount);

    [PreserveSig]
    unsafe int GetExtraAxisIndexes(GameInputKind inputKind, uint extraAxisCount, byte* extraAxisIndexes);

    [PreserveSig]
    unsafe int GetExtraButtonIndexes(GameInputKind inputKind, uint extraButtonCount, byte* extraButtonIndexes);

    [PreserveSig]
    int CreateRawDeviceReport(uint reportId, GameInputRawDeviceReportKind reportKind,
        out IGameInputRawDeviceReport? report);

    [PreserveSig]
    int SendRawDeviceOutput([MarshalAs(UnmanagedType.Interface)] IGameInputRawDeviceReport report);
}