using System.Runtime.Versioning;
using GameInputDotNet;
using GameInputDotNet.Interop.Enums;
using GameInputDotNet.Interop.Tests.Infrastructure;

namespace GameInputDotNet.Interop.Tests;

public sealed class GameInputEnumerationSmokeTests
{
    [WindowsOnlyFact]
    [SupportedOSPlatform("windows")]
    public void EnumerateDevices_CompletesAndDisposes()
    {
        using var gameInput = GameInputFactory.Create();
        var devices = gameInput.EnumerateDevices(GameInputKind.Controller);

        foreach (var device in devices)
        {
            device.Dispose();
        }
    }
}
