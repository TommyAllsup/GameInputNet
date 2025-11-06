using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputSystemButtons : uint
{
    None = 0x00000000,
    Guide = 0x00000001,
    Share = 0x00000002
}
