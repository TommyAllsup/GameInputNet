using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputFeedbackAxes : uint
{
    None = 0x00000000,
    LinearX = 0x00000001,
    LinearY = 0x00000002,
    LinearZ = 0x00000004,
    AngularX = 0x00000008,
    AngularY = 0x00000010,
    AngularZ = 0x00000020,
    Normal = 0x00000040
}
