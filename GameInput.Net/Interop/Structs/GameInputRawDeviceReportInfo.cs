using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputRawDeviceReportInfo
{
    public GameInputRawDeviceReportKind Kind;
    public uint Id;
    public uint Size;
}