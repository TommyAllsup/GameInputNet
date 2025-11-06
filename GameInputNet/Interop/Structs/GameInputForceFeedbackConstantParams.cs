using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackConstantParams
{
    public GameInputForceFeedbackEnvelope Envelope;
    public GameInputForceFeedbackMagnitude Magnitude;
}
