using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputAxisMapping
{
    public GameInputElementKind ControllerElementKind;
    public uint ControllerIndex;

    [MarshalAs(UnmanagedType.I1)] public bool IsInverted;

    [MarshalAs(UnmanagedType.I1)] public bool FromTwoButtons;

    public uint ButtonMinIndexValue;
    public GameInputSwitchPosition ReferenceDirection;
}