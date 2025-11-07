using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using GameInputDotNet.Interop.Enums;
using GameInputDotNet.Interop.Handles;
using GameInputDotNet.Interop.Interfaces;
using GameInputDotNet.Interop.Structs;

namespace GameInputDotNet;

/// <summary>
///     Managed wrapper over a native <c>IGameInputDevice</c> interface.
/// </summary>
[SupportedOSPlatform("windows")]
public sealed class GameInputDevice : IDisposable
{
    private GameInputDeviceHandle? _handle;

    internal GameInputDevice(GameInputDeviceHandle handle, ulong timestamp, GameInputDeviceStatus currentStatus,
        GameInputDeviceStatus previousStatus)
    {
        ArgumentNullException.ThrowIfNull(handle);

        _handle = handle;
        LastSeenTimestamp = timestamp;
        CurrentStatus = currentStatus;
        PreviousStatus = previousStatus;
    }

    /// <summary>
    ///     Timestamp provided by the GameInput runtime when this device was observed.
    /// </summary>
    public ulong LastSeenTimestamp { get; }

    /// <summary>
    ///     Device status reported during enumeration.
    /// </summary>
    public GameInputDeviceStatus CurrentStatus { get; }

    /// <summary>
    ///     Previous status reported by the runtime prior to this enumeration result.
    /// </summary>
    public GameInputDeviceStatus PreviousStatus { get; }

    internal IGameInputDevice NativeInterface =>
        _handle?.GetInterface() ?? throw new ObjectDisposedException(nameof(GameInputDevice));

    /// <summary>
    ///     Retrieves the current device information block from the GameInput runtime.
    /// </summary>
    public unsafe GameInputDeviceInfo GetDeviceInfo()
    {
        var hr = NativeInterface.GetDeviceInfo(out GameInputDeviceInfo* info);
        GameInputException.ThrowIfFailed(hr, "IGameInputDevice.GetDeviceInfo failed.");

        if (info is null)
        {
            throw new GameInputException("IGameInputDevice.GetDeviceInfo returned a null pointer.", hr);
        }

        return *info;
    }

    /// <summary>
    ///     Retrieves the latest device status value from the GameInput runtime.
    /// </summary>
    public GameInputDeviceStatus GetCurrentStatus()
    {
        return NativeInterface.GetDeviceStatus();
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _handle?.Dispose();
        _handle = null;
        GC.SuppressFinalize(this);
    }
}
