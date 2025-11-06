using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputButtonMapping
{
    public GameInputElementKind ControllerElementKind;
    public uint ControllerIndex;

    [MarshalAs(UnmanagedType.I1)]
    public bool IsInverted;

    public GameInputSwitchPosition SwitchPosition;
}
