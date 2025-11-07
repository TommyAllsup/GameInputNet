using System;
using System.Linq;
using GameInputDotNet.Interop.Tests.Infrastructure;
using Xunit;

namespace GameInputDotNet.Interop.Tests;

public sealed class GameInputHeaderManifestTests
{
    private static readonly GameInputHeaderManifest Manifest = GameInputHeaderManifest.Load();

    [Fact]
    public void CallbackTypedefsMatchHeader()
    {
        var expectedNames = new[]
        {
            "GameInputReadingCallback",
            "GameInputDeviceCallback",
            "GameInputSystemButtonCallback",
            "GameInputKeyboardLayoutCallback"
        };

        var actualNames = Manifest.CallbackTypedefs
            .Select(callback => callback.Name)
            .OrderBy(name => name, StringComparer.Ordinal)
            .ToArray();

        Assert.Equal(expectedNames.OrderBy(name => name, StringComparer.Ordinal).ToArray(), actualNames);
    }

    [Fact]
    public void CallbackCallingConventionTokensAreCaptured()
    {
        foreach (var callback in Manifest.CallbackTypedefs)
        {
            Assert.Equal("CALLBACK", callback.CallingConventionToken);
            Assert.False(string.IsNullOrWhiteSpace(callback.ParameterSignature));
        }
    }
}
