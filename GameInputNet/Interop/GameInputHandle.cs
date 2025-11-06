// Interop/GameInputHandle.cs

using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Microsoft.Win32.SafeHandles;

namespace GameInputNet.Interop;

/// <summary>
///     Safe wrapper over the unmanaged IGameInput COM pointer.
/// </summary>
[SupportedOSPlatform("windows")]
internal sealed class GameInputHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    private GameInputNative.IGameInput? _gameInput;

    private GameInputHandle()
        : base(true)
    {
    }

    public static GameInputHandle FromInterface(GameInputNative.IGameInput gameInput)
    {
        var handle = new GameInputHandle
        {
            handle = Marshal.GetIUnknownForObject(gameInput)
        };

        // GetIUnknownForObject adds a ref; keep the RCW alive so ReleaseHandle
        // decrements the same ref count we just incremented.
        handle._gameInput = gameInput;
        return handle;
    }

    public GameInputNative.IGameInput GetInterface()
    {
        ObjectDisposedException.ThrowIf(handle == IntPtr.Zero, "GameInputHandle object can not be disposed.");

        return _gameInput ??= (GameInputNative.IGameInput)Marshal.GetObjectForIUnknown(handle);
    }

    protected override bool ReleaseHandle()
    {
        Marshal.Release(handle);
        _gameInput = null;
        return true;
    }
}