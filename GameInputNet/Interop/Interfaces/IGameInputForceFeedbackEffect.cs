using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;
using GameInputNet.Interop.Structs;

namespace GameInputNet.Interop.Interfaces;

[ComImport]
[Guid("FF61096A-3373-4093-A1DF-6D31846B3511")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInputForceFeedbackEffect
{
    [PreserveSig]
    void GetDevice(out IGameInputDevice? device);

    [PreserveSig]
    uint GetMotorIndex();

    [PreserveSig]
    float GetGain();

    [PreserveSig]
    void SetGain(float gain);

    [PreserveSig]
    unsafe void GetParams(GameInputForceFeedbackParams* @params);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool SetParams(GameInputForceFeedbackParams* @params);

    [PreserveSig]
    GameInputFeedbackEffectState GetState();

    [PreserveSig]
    void SetState(GameInputFeedbackEffectState state);
}
