using System.Diagnostics.CodeAnalysis;

namespace GameInputDotNet.Interop;

internal static class HResult
{
    public const int S_OK = 0;

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Matches Win32 naming.")]
    public static bool SUCCEEDED(int value)
    {
        return value >= 0;
    }

    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Matches Win32 naming.")]
    public static bool FAILED(int value)
    {
        return value < 0;
    }
}