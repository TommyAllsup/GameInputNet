namespace GameInputDotNet.Interop.Enums;

[Flags]
public enum GameInputFocusPolicy : uint
{
    Default = 0x00000000,
    ExclusiveForegroundInput = 0x00000002,
    ExclusiveForegroundGuideButton = 0x00000008,
    ExclusiveForegroundShareButton = 0x00000020,
    EnableBackgroundInput = 0x00000040,
    EnableBackgroundGuideButton = 0x00000080,
    EnableBackgroundShareButton = 0x00000100
}