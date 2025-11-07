using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputSensorsState
{
    public float AccelerationInGx;
    public float AccelerationInGy;
    public float AccelerationInGz;

    public float AngularVelocityInRadPerSecX;
    public float AngularVelocityInRadPerSecY;
    public float AngularVelocityInRadPerSecZ;

    public float HeadingInDegreesFromMagneticNorth;
    public GameInputSensorAccuracy HeadingAccuracy;

    public float OrientationW;
    public float OrientationX;
    public float OrientationY;
    public float OrientationZ;
}