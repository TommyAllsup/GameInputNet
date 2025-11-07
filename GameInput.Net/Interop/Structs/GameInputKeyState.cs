using System.Runtime.InteropServices;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputKeyState
{
    public uint ScanCode;
    public uint CodePoint;
    public byte VirtualKey;

    [MarshalAs(UnmanagedType.I1)] public bool IsDeadKey;
}