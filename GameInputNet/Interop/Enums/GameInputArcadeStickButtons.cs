using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputArcadeStickButtons : uint
{
    None = 0x00000000,
    Menu = 0x00000001,
    View = 0x00000002,
    Up = 0x00000004,
    Down = 0x00000008,
    Left = 0x00000010,
    Right = 0x00000020,
    Action1 = 0x00000040,
    Action2 = 0x00000080,
    Action3 = 0x00000100,
    Action4 = 0x00000200,
    Action5 = 0x00000400,
    Action6 = 0x00000800,
    Special1 = 0x00001000,
    Special2 = 0x00002000
}
