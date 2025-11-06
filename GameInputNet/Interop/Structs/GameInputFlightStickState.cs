using System.Runtime.InteropServices;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public struct GameInputFlightStickState
{
    public GameInputFlightStickButtons Buttons;
    public GameInputSwitchPosition HatSwitch;
    public float Roll;
    public float Pitch;
    public float Yaw;
    public float Throttle;
}
