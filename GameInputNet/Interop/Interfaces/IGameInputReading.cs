using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;
using GameInputNet.Interop.Structs;

namespace GameInputNet.Interop.Interfaces;

[ComImport]
[Guid("C81C4CDE-ED1A-4631-A30F-C556A6241A1F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInputReading
{
    [PreserveSig]
    GameInputKind GetInputKind();

    [PreserveSig]
    ulong GetTimestamp();

    [PreserveSig]
    void GetDevice([MarshalAs(UnmanagedType.Interface)] out IGameInputDevice? device);

    [PreserveSig]
    uint GetControllerAxisCount();

    [PreserveSig]
    unsafe uint GetControllerAxisState(uint stateArrayCount, float* stateArray);

    [PreserveSig]
    uint GetControllerButtonCount();

    [PreserveSig]
    unsafe uint GetControllerButtonState(uint stateArrayCount, bool* stateArray);

    [PreserveSig]
    uint GetControllerSwitchCount();

    [PreserveSig]
    unsafe uint GetControllerSwitchState(uint stateArrayCount, GameInputSwitchPosition* stateArray);

    [PreserveSig]
    uint GetKeyCount();

    [PreserveSig]
    unsafe uint GetKeyState(uint stateArrayCount, GameInputKeyState* stateArray);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetMouseState(GameInputMouseState* state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetSensorsState(GameInputSensorsState* state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetArcadeStickState(GameInputArcadeStickState* state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetFlightStickState(GameInputFlightStickState* state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetGamepadState(GameInputGamepadState* state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetRacingWheelState(GameInputRacingWheelState* state);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    bool GetRawReport(out IGameInputRawDeviceReport? report);
}
