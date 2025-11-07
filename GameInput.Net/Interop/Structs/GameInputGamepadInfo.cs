using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputGamepadInfo
{
    public GameInputGamepadButtons SupportedLayout;
    public GameInputLabel MenuButtonLabel;
    public GameInputLabel ViewButtonLabel;
    public GameInputLabel AButtonLabel;
    public GameInputLabel BButtonLabel;
    public GameInputLabel CButtonLabel;
    public GameInputLabel XButtonLabel;
    public GameInputLabel YButtonLabel;
    public GameInputLabel ZButtonLabel;
    public GameInputLabel DpadUpLabel;
    public GameInputLabel DpadDownLabel;
    public GameInputLabel DpadLeftLabel;
    public GameInputLabel DpadRightLabel;
    public GameInputLabel LeftShoulderButtonLabel;
    public GameInputLabel RightShoulderButtonLabel;
    public GameInputLabel LeftThumbstickButtonLabel;
    public GameInputLabel RightThumbstickButtonLabel;
    public uint extraButtonCount;
    public uint extraAxisCount;
}