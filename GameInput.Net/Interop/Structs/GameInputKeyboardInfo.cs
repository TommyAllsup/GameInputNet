using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputKeyboardInfo
{
    public GameInputKeyboardKind Kind;
    public uint Layout;
    public uint KeyCount;
    public uint functionKeyCount;
    public uint MaxSimultaneousKeys;
    public uint platformType;
    public uint platformSubType;
}