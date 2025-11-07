using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputMouseInfo
{
    public GameInputMouseButtons SupportedButtons;
    public uint SampleRate;

    [MarshalAs(UnmanagedType.I1)] public bool HasWheelX;

    [MarshalAs(UnmanagedType.I1)] public bool HasWheelY;
}