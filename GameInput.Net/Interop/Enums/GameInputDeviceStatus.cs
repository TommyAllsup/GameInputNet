namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputDeviceStatus : uint
{
    None = 0x00000000,
    Connected = 0x00000001,
    HapticInfoReady = 0x00200000,
    Any = 0xFFFFFFFF
}