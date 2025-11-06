using System;

namespace GameInputNet.Interop.Enums;

[Flags]
public enum GameInputRacingWheelAxes : uint
{
    AxesNone = 0x00000000,
    Steering = 0x00000100,
    Throttle = 0x00000200,
    Brake = 0x00000400,
    Clutch = 0x00000800,
    Handbrake = 0x00001000,
    PatternShifter = 0x00002000
}
