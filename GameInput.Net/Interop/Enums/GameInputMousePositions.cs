namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputMousePositions : uint
{
    NoPosition = 0x00000000,
    AbsolutePosition = 0x00000001,
    RelativePosition = 0x00000002
}