namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputSensorsKind : uint
{
    None = 0x00000000,
    Accelerometer = 0x00000001,
    Gyrometer = 0x00000002,
    Compass = 0x00000004,
    Orientation = 0x00000008
}