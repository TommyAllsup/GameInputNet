using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputGamepadButtons : uint
{
    None = 0x00000000,
    Menu = 0x00000001,
    View = 0x00000002,
    A = 0x00000004,
    B = 0x00000008,
    C = 0x00004000,
    X = 0x00000010,
    Y = 0x00000020,
    Z = 0x00008000,
    DPadUp = 0x00000040,
    DPadDown = 0x00000080,
    DPadLeft = 0x00000100,
    DPadRight = 0x00000200,
    LeftShoulder = 0x00000400,
    RightShoulder = 0x00000800,
    LeftTriggerButton = 0x00010000,
    RightTriggerButton = 0x00020000,
    LeftThumbstick = 0x00001000,
    LeftThumbstickUp = 0x00040000,
    LeftThumbstickDown = 0x00080000,
    LeftThumbstickLeft = 0x00100000,
    LeftThumbstickRight = 0x00200000,
    RightThumbstick = 0x00002000,
    RightThumbstickUp = 0x00400000,
    RightThumbstickDown = 0x00800000,
    RightThumbstickLeft = 0x01000000,
    RightThumbstickRight = 0x02000000,
    PaddleLeft1 = 0x04000000,
    PaddleLeft2 = 0x08000000,
    PaddleRight1 = 0x10000000,
    PaddleRight2 = 0x20000000
}
