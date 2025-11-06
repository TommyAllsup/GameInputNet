using System.Runtime.InteropServices;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackMagnitude
{
    public float LinearX;
    public float LinearY;
    public float LinearZ;
    public float AngularX;
    public float AngularY;
    public float AngularZ;
    public float Normal;
}
