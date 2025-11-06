using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputRawDeviceReportInfo
{
    public GameInputRawDeviceReportKind Kind;
    public uint Id;
    public uint Size;
}
