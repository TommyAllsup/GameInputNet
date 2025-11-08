using System;
using System.Reflection;
using System.Runtime.InteropServices;
using GameInputDotNet.Interop.Interfaces;

namespace GameInputDotNet.Interop;

public static class GameInputNative
{
    private const string GameInputDll = "GameInput.dll";
    private const string GameInputRedistDll = "GameInputRedist.dll";

    static GameInputNative()
    {
        NativeLibrary.SetDllImportResolver(typeof(GameInputNative).Assembly, ResolveLibrary);
    }

    private static IntPtr ResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (!string.Equals(libraryName, GameInputDll, StringComparison.OrdinalIgnoreCase))
        {
            return IntPtr.Zero;
        }

        if (NativeLibrary.TryLoad(GameInputRedistDll, assembly, searchPath, out var handle))
        {
            return handle;
        }

        if (NativeLibrary.TryLoad(GameInputDll, assembly, searchPath, out handle))
        {
            return handle;
        }

        return IntPtr.Zero;
    }

    [DllImport(GameInputDll, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern int GameInputCreate(out IGameInput? gameInput);
}
