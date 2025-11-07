namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputGamepadAxes : uint
{
    AxesNone = 0x00000000,
    LeftTrigger = 0x00000001,
    RightTrigger = 0x00000002,
    LeftThumbstickX = 0x00000004,
    LeftThumbstickY = 0x00000008,
    RightThumbstickX = 0x00000010,
    RightThumbstickY = 0x00000020
}