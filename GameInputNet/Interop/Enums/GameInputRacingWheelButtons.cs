using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputRacingWheelButtons : uint
{
    None = 0x00000000,
    Menu = 0x00000001,
    View = 0x00000002,
    PreviousGear = 0x00000004,
    NextGear = 0x00000008,
    A = 0x00000100,
    B = 0x00000200,
    X = 0x00000400,
    Y = 0x00000800,
    DpadUp = 0x00000010,
    DpadDown = 0x00000020,
    DpadLeft = 0x00000040,
    DpadRight = 0x00000080,
    LeftThumbstick = 0x00001000,
    RightThumbstick = 0x00002000
}
