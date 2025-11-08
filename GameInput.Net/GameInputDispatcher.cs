using System;
using System.Runtime.Versioning;
using GameInputDotNet.Interop;
using GameInputDotNet.Interop.Handles;
using GameInputDotNet.Interop.Interfaces;
using Microsoft.Win32.SafeHandles;

namespace GameInputDotNet;

/// <summary>
///     Managed wrapper over the native <c>IGameInputDispatcher</c> interface.
/// </summary>
[SupportedOSPlatform("windows")]
public sealed class GameInputDispatcher : IDisposable
{
    private GameInputDispatcherHandle? _handle;

    internal GameInputDispatcher(GameInputDispatcherHandle handle)
    {
        ArgumentNullException.ThrowIfNull(handle);
        _handle = handle;
    }

    internal IGameInputDispatcher NativeInterface =>
        _handle?.GetInterface() ?? throw new ObjectDisposedException(nameof(GameInputDispatcher));

    public void Dispose()
    {
        _handle?.Dispose();
        _handle = null;
        GC.SuppressFinalize(this);
    }

    /// <summary>
    ///     Dispatches queued callbacks for up to the specified quota.
    /// </summary>
    /// <param name="quota">Maximum time to spend dispatching callbacks.</param>
    /// <returns><c>true</c> if callbacks remain pending after the dispatch; otherwise <c>false</c>.</returns>
    public bool Dispatch(TimeSpan quota)
    {
        if (quota < TimeSpan.Zero) throw new ArgumentOutOfRangeException(nameof(quota));

        var microseconds = ConvertToMicroseconds(quota);
        return Dispatch(microseconds);
    }

    /// <summary>
    ///     Dispatches queued callbacks for up to the specified quota expressed in microseconds.
    /// </summary>
    public bool Dispatch(ulong quotaInMicroseconds)
    {
        return NativeInterface.Dispatch(quotaInMicroseconds);
    }

    /// <summary>
    ///     Opens a wait handle that can be used with native waiting primitives.
    /// </summary>
    public SafeWaitHandle OpenWaitHandle()
    {
        var hr = NativeInterface.OpenWaitHandle(out var handle);
        GameInputErrorMapper.ThrowIfFailed(hr, "IGameInputDispatcher.OpenWaitHandle failed.");
        if (handle == IntPtr.Zero)
        {
            throw new GameInputException("IGameInputDispatcher.OpenWaitHandle returned a null handle.",
                unchecked((int)0x80004003));
        }

        return new SafeWaitHandle(handle, ownsHandle: true);
    }

    private static ulong ConvertToMicroseconds(TimeSpan quota)
    {
        // 1 tick = 100 nanoseconds, 1 microsecond = 1000 nanoseconds = 10 ticks.
        var microseconds = quota.Ticks / 10;
        return microseconds <= 0 ? 0UL : (ulong)microseconds;
    }
}
