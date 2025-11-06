using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputRacingWheelInfo
{
    public GameInputLabel MenuButtonLabel;
    public GameInputLabel ViewButtonLabel;
    public GameInputLabel PreviousGearButtonLabel;
    public GameInputLabel NextGearButtonLabel;
    public GameInputLabel DpadUpLabel;
    public GameInputLabel DpadDownLabel;
    public GameInputLabel DpadLeftLabel;
    public GameInputLabel DpadRightLabel;
    public GameInputLabel AButtonLabel;
    public GameInputLabel BButtonLabel;
    public GameInputLabel XButtonLabel;
    public GameInputLabel YButtonLabel;
    public GameInputLabel LeftThumbstickButtonLabel;
    public GameInputLabel RightThumbstickButtonLabel;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasClutch;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasHandbrake;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasPatternShifter;

    [MarshalAs(UnmanagedType.I1)]
    public bool HasPatternShifterGear;

    [MarshalAs(UnmanagedType.I1)]
    public bool MinPatternShifterGear;

    [MarshalAs(UnmanagedType.I1)]
    public bool MaxPatternShifterGear;

    public float MaxWheelAngle;
    public uint extraButtonCount;
    public uint extraAxisCount;
}
