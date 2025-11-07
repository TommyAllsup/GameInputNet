namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputKind : uint
{
    Unknown = 0x00000000,
    RawDeviceReport = 0x00000001,
    ControllerAxis = 0x00000002,
    ControllerButton = 0x00000004,
    ControllerSwitch = 0x00000008,
    Controller = 0x0000000E,
    Keyboard = 0x00000010,
    Mouse = 0x00000020,
    Sensors = 0x00000040,
    ArcadeStick = 0x00010000,
    FlightStick = 0x00020000,
    Gamepad = 0x00040000,
    RacingWheel = 0x00080000
}