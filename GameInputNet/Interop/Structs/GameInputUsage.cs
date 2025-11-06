using System;
using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputUsage
{
    public ushort page;
    public ushort id;
}
