using System.Runtime.InteropServices;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputRumbleParams
{
    public float LowFrequency;
    public float HighFrequency;
    public float LeftTrigger;
    public float RightTrigger;
}