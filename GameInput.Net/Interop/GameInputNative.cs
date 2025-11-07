using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Interfaces;

namespace GameInputDotNet.Interop;

public static class GameInputNative
{
    private const string GameInputDll = "GameInput.dll";

    [DllImport(GameInputDll, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern int GameInputCreate(out IGameInput? gameInput);
}