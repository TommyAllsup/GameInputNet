using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputFlightStickInfo
{
    public GameInputLabel MenuButtonLabel;
    public GameInputLabel ViewButtonLabel;
    public GameInputLabel FirePrimaryButtonLabel;
    public GameInputLabel FireSecondaryButtonLabel;
    public GameInputLabel HatSwitchUpLabel;
    public GameInputLabel HatSwitchDownLabel;
    public GameInputLabel HatSwitchLeftLabel;
    public GameInputLabel HatSwitchRightLabel;
    public GameInputLabel AButtonLabel;
    public GameInputLabel BButtonLabel;
    public GameInputLabel XButtonLabel;
    public GameInputLabel YButtonLabel;
    public GameInputLabel LeftShoulderButtonLabel;
    public GameInputLabel RightShoulderButtonLabel;
    public uint extraButtonCount;
    public uint extraAxisCount;
}
