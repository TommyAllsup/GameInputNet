using System.Runtime.InteropServices;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackRampParams
{
    public GameInputForceFeedbackEnvelope Envelope;
    public GameInputForceFeedbackMagnitude StartMagnitude;
    public GameInputForceFeedbackMagnitude EndMagnitude;
}