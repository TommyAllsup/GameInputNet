using System.Runtime.InteropServices;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackEnvelope
{
    public ulong AttackDuration;
    public ulong SustainDuration;
    public ulong ReleaseDuration;
    public float AttackGain;
    public float SustainGain;
    public float ReleaseGain;
    public uint PlayCount;
    public ulong RepeatDelay;
}