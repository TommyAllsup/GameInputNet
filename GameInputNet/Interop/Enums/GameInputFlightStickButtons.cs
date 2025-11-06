using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputFlightStickButtons : uint
{
    None = 0x00000000,
    Menu = 0x00000001,
    View = 0x00000002,
    FirePrimary = 0x00000004,
    FireSecondary = 0x00000008,
    HatSwitchUp = 0x00000010,
    HatSwitchDown = 0x00000020,
    HatSwitchLeft = 0x00000040,
    HatSwitchRight = 0x00000080,
    A = 0x00000100,
    B = 0x00000200,
    X = 0x00000400,
    Y = 0x00000800,
    LeftShoulder = 0x00001000,
    RightShoulder = 0x00002000
}
