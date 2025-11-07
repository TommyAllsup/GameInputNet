using System.Runtime.InteropServices;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputVersion
{
    public ushort Major;
    public ushort Minor;
    public ushort Build;
    public ushort Revision;
}