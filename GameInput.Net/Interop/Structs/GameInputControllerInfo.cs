using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Enums;

namespace GameInputDotNet.Interop.Structs;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct GameInputControllerInfo
{
    private uint _controllerAxisCount;
    private GameInputLabel* _controllerAxisLabels;
    private uint _controllerButtonCount;
    private GameInputLabel* _controllerButtonLabels;
    private uint _controllerSwitchCount;
    private GameInputControllerSwitchInfo* _controllerSwitchInfo;
}

public partial struct GameInputControllerInfo
{
    public uint GetControllerAxisCount()
    {
        return _controllerAxisCount;
    }

    public uint GetControllerButtonCount()
    {
        return _controllerButtonCount;
    }

    public uint GetControllerSwitchCount()
    {
        return _controllerSwitchCount;
    }

    public ReadOnlySpan<GameInputLabel> GetControllerAxisLabels()
    {
        if (_controllerAxisCount == 0) return ReadOnlySpan<GameInputLabel>.Empty;

        unsafe
        {
            return _controllerAxisLabels is null
                ? ReadOnlySpan<GameInputLabel>.Empty
                : new ReadOnlySpan<GameInputLabel>(_controllerAxisLabels, checked((int)_controllerAxisCount));
        }
    }

    public ReadOnlySpan<GameInputLabel> GetControllerButtonLabels()
    {
        if (_controllerButtonCount == 0) return ReadOnlySpan<GameInputLabel>.Empty;

        unsafe
        {
            return _controllerButtonLabels is null
                ? ReadOnlySpan<GameInputLabel>.Empty
                : new ReadOnlySpan<GameInputLabel>(_controllerButtonLabels, checked((int)_controllerButtonCount));
        }
    }

    public ReadOnlySpan<GameInputControllerSwitchInfo> GetControllerSwitchInfo()
    {
        if (_controllerSwitchCount == 0) return ReadOnlySpan<GameInputControllerSwitchInfo>.Empty;

        unsafe
        {
            return _controllerSwitchInfo is null
                ? ReadOnlySpan<GameInputControllerSwitchInfo>.Empty
                : new ReadOnlySpan<GameInputControllerSwitchInfo>(_controllerSwitchInfo,
                    checked((int)_controllerSwitchCount));
        }
    }
}