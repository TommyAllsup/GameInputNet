using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackConditionParams
{
    public GameInputForceFeedbackMagnitude magnitude;
    public float PositiveCoefficient;
    public float NegativeCoefficient;
    public float MaxPositiveMagnitude;
    public float MaxNegativeMagnitude;
    public float DeadZone;
    public float Bias;
}
