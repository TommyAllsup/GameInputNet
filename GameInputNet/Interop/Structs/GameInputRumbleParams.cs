using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputRumbleParams
{
    public float LowFrequency;
    public float HighFrequency;
    public float LeftTrigger;
    public float RightTrigger;
}
