using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputSensorsInfo
{
    public GameInputSensorsKind SupportedSensors;
}
