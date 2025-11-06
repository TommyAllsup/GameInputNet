using System.Runtime.InteropServices;

namespace GameInputNet.Interop;

public partial struct GameInputHapticInfo
{
    public string GetAudioEndpointId()
    {
        unsafe
        {
            fixed (char* ptr = _audioEndpointId)
            {
                return Marshal.PtrToStringUni((nint)ptr) ?? string.Empty;
            }
        }
    }

    public void SetAudioEndpointId(ReadOnlySpan<char> value)
    {
        if (value.Length >= Constants.GAMEINPUT_HAPTIC_MAX_AUDIO_ENDPOINT_ID_SIZE)
        {
            throw new ArgumentException(
                $"Audio endpoint ID must be shorter than {Constants.GAMEINPUT_HAPTIC_MAX_AUDIO_ENDPOINT_ID_SIZE} characters.",
                nameof(value));
        }

        unsafe
        {
            fixed (char* ptr = _audioEndpointId)
            {
                value.CopyTo(new Span<char>(ptr, Constants.GAMEINPUT_HAPTIC_MAX_AUDIO_ENDPOINT_ID_SIZE));
                ptr[value.Length] = '\0';
            }
        }
    }

    public ReadOnlySpan<Guid> GetLocations()
    {
        if (LocationCount == 0)
        {
            return ReadOnlySpan<Guid>.Empty;
        }

        unsafe
        {
            fixed (byte* ptr = _locations)
            {
                var raw = new ReadOnlySpan<byte>(ptr,
                    Constants.GAMEINPUT_HAPTIC_MAX_LOCATIONS * 16);
                return MemoryMarshal.Cast<byte, Guid>(raw)
                    .Slice(0, checked((int)LocationCount));
            }
        }
    }

    public void SetLocation(int index, Guid value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        if (index >= Constants.GAMEINPUT_HAPTIC_MAX_LOCATIONS)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        unsafe
        {
            fixed (byte* ptr = _locations)
            {
                var span = MemoryMarshal.Cast<byte, Guid>(
                    new Span<byte>(ptr, Constants.GAMEINPUT_HAPTIC_MAX_LOCATIONS * 16));
                span[index] = value;
            }
        }
    }
}
