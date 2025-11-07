using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputMouseState
{
    public GameInputMouseButtons Buttons;
    public GameInputMousePositions Positions;
    public long PositionX;
    public long PositionY;
    public long AbsolutePositionX;
    public long AbsolutePositionY;
    public long WheelX;
    public long WheelY;
}