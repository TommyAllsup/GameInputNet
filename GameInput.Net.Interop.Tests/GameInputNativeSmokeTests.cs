using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using GameInputDotNet.Interop;
using GameInputDotNet.Interop.Interfaces;
using GameInputDotNet.Interop.Tests.Infrastructure;
using Xunit;

namespace GameInputDotNet.Interop.Tests;

public sealed class GameInputNativeSmokeTests
{
    [WindowsOnlyFact]
    [SupportedOSPlatform("windows")]
    public void GameInputLibraryIsDeployedToTestOutput()
    {
        var nativePath = ResolveNativePath();
        Assert.True(File.Exists(nativePath),
            $"GameInput.dll should exist at '{nativePath}' for smoke tests.");
    }

    [WindowsOnlyFact]
    [SupportedOSPlatform("windows")]
    public void GameInputCreateReturnsSuccessAndReleasesInterface()
    {
        var hr = GameInputNative.GameInputCreate(out var gameInput);
        Assert.Equal(0, hr);

        if (gameInput is not null)
        {
            try
            {
                Marshal.FinalReleaseComObject(gameInput);
            }
            catch (ArgumentException)
            {
                // Fallback when FinalReleaseComObject rejects proxy types; ensure at least one release.
                Marshal.ReleaseComObject(gameInput);
            }
        }
    }

    private static string ResolveNativePath()
    {
        var baseDirectory = AppContext.BaseDirectory;
        return Path.Combine(baseDirectory, "GameInput.dll");
    }
}
