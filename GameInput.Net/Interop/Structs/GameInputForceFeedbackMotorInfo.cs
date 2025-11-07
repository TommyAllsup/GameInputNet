using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputForceFeedbackMotorInfo
{
    public GameInputFeedbackAxes SupportedAxes;

    [MarshalAs(UnmanagedType.I1)] public bool IsConstantEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsRampEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsSineWaveEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsSquareWaveEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsTriangleWaveEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsSawtoothUpWaveEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsSawtoothDownWaveEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsSpringEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsFrictionEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsDamperEffectSupported;

    [MarshalAs(UnmanagedType.I1)] public bool IsInertiaEffectSupported;
}