using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackPeriodicParams
{
    public GameInputForceFeedbackEnvelope Envelope;
    public GameInputForceFeedbackMagnitude Magnitude;
    public float Frequency;
    public float Phase;
    public float Bias;
}
