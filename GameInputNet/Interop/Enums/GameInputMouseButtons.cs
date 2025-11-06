using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputMouseButtons : uint
{
    None = 0x00000000,
    Left = 0x00000001,
    Right = 0x00000002,
    Middle = 0x00000004,
    Button4 = 0x00000008,
    Button5 = 0x00000010,
    WheelTiltLeft = 0x00000020,
    WheelTiltRight = 0x00000040
}
