namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputFlightStickAxes : uint
{
    AxesNone = 0x00000000,
    Roll = 0x00000010,
    Pitch = 0x00000020,
    Yaw = 0x00000040,
    Throttle = 0x00000080
}