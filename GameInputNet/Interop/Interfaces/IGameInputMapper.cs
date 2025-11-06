using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;
using GameInputNet.Interop.Structs;

namespace GameInputNet.Interop.Interfaces;

[ComImport]
[Guid("3C600700-F16C-49CE-9BE6-6A2EF752ED5E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IGameInputMapper
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetArcadeStickButtonMappingInfo(GameInputArcadeStickButtons buttonElement,
        GameInputButtonMapping* mapping);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetFlightStickAxisMappingInfo(GameInputFlightStickAxes axisElement,
        GameInputAxisMapping* mapping);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetFlightStickButtonMappingInfo(GameInputFlightStickButtons buttonElement,
        GameInputButtonMapping* mapping);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetGamepadAxisMappingInfo(GameInputGamepadAxes axisElement, GameInputAxisMapping* mapping);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetGamepadButtonMappingInfo(GameInputGamepadButtons buttonElement,
        GameInputButtonMapping* mapping);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetRacingWheelAxisMappingInfo(GameInputRacingWheelAxes axisElement,
        GameInputAxisMapping* mapping);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Bool)]
    unsafe bool GetRacingWheelButtonMappingInfo(GameInputRacingWheelButtons buttonElement,
        GameInputButtonMapping* mapping);
}
