using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputArcadeStickInfo
{
    public GameInputLabel MenuButtonLabel;
    public GameInputLabel ViewButtonLabel;
    public GameInputLabel StickUpLabel;
    public GameInputLabel StickDownLabel;
    public GameInputLabel StickLeftLabel;
    public GameInputLabel StickRightLabel;
    public GameInputLabel ActionButton1Label;
    public GameInputLabel ActionButton2Label;
    public GameInputLabel ActionButton3Label;
    public GameInputLabel ActionButton4Label;
    public GameInputLabel ActionButton5Label;
    public GameInputLabel ActionButton6Label;
    public GameInputLabel SpecialButton1Label;
    public GameInputLabel SpecialButton2Label;
    public uint ExtraButtonCount;
    public uint ExtraAxisCount;
}
