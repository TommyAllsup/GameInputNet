using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputRacingWheelState
{
    public GameInputRacingWheelButtons Buttons;
    public int PatternShifterGear;
    public float Wheel;
    public float Throttle;
    public float Brake;
    public float Clutch;
    public float Handbrake;
}