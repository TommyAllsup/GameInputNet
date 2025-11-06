using System;
using System.Runtime.InteropServices;
using GameInputNet.Interop;
using GameInputNet.Interop.Enums;

namespace GameInputNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct GameInputControllerSwitchInfo
{
    private fixed int _labels[Constants.GAMEINPUT_MAX_SWITCH_STATES];
    public GameInputSwitchKind Kind;
}

public partial struct GameInputControllerSwitchInfo
{
    public ReadOnlySpan<GameInputLabel> GetLabels()
    {
        unsafe
        {
            fixed (int* ptr = _labels)
            {
                var raw = new ReadOnlySpan<int>(ptr, Constants.GAMEINPUT_MAX_SWITCH_STATES);
                return MemoryMarshal.Cast<int, GameInputLabel>(raw);
            }
        }
    }

    internal unsafe GameInputLabel* GetLabelsPointer()
    {
        fixed (int* ptr = _labels)
        {
            return (GameInputLabel*)ptr;
        }
    }
}
