namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputRumbleMotors
{
    None = 0x00000000,
    LowFrequency = 0x00000001,
    HighFrequency = 0x00000002,
    LeftTrigger = 0x00000004,
    RightTrigger = 0x00000008
}