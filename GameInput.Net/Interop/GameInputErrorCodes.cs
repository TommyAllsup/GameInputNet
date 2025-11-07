namespace GameInputDotNet.Interop;

internal static class GameInputErrorCodes
{
    public const int GAMEINPUT_E_DEVICE_DISCONNECTED = unchecked((int)0x838A0001);
    public const int GAMEINPUT_E_DEVICE_NOT_FOUND = unchecked((int)0x838A0002);
    public const int GAMEINPUT_E_READING_NOT_FOUND = unchecked((int)0x838A0003);
    public const int GAMEINPUT_E_REFERENCE_READING_TOO_OLD = unchecked((int)0x838A0004);
    public const int GAMEINPUT_E_FEEDBACK_NOT_SUPPORTED = unchecked((int)0x838A0007);
    public const int GAMEINPUT_E_OBJECT_NO_LONGER_EXISTS = unchecked((int)0x838A0008);
    public const int GAMEINPUT_E_CALLBACK_NOT_FOUND = unchecked((int)0x838A0009);
    public const int GAMEINPUT_E_HAPTIC_INFO_NOT_FOUND = unchecked((int)0x838A000A);
    public const int GAMEINPUT_E_AGGREGATE_OPERATION_NOT_SUPPORTED = unchecked((int)0x838A000B);
    public const int GAMEINPUT_E_INPUT_KIND_NOT_PRESENT = unchecked((int)0x838A000C);
}

internal enum GameInputError
{
    DeviceDisconnected = GameInputErrorCodes.GAMEINPUT_E_DEVICE_DISCONNECTED,
    DeviceNotFound = GameInputErrorCodes.GAMEINPUT_E_DEVICE_NOT_FOUND,
    ReadingNotFound = GameInputErrorCodes.GAMEINPUT_E_READING_NOT_FOUND,
    ReferenceReadingTooOld = GameInputErrorCodes.GAMEINPUT_E_REFERENCE_READING_TOO_OLD,
    FeedbackNotSupported = GameInputErrorCodes.GAMEINPUT_E_FEEDBACK_NOT_SUPPORTED,
    ObjectNoLongerExists = GameInputErrorCodes.GAMEINPUT_E_OBJECT_NO_LONGER_EXISTS,
    CallbackNotFound = GameInputErrorCodes.GAMEINPUT_E_CALLBACK_NOT_FOUND,
    HapticInfoNotFound = GameInputErrorCodes.GAMEINPUT_E_HAPTIC_INFO_NOT_FOUND,
    AggregateOperationNotSupported = GameInputErrorCodes.GAMEINPUT_E_AGGREGATE_OPERATION_NOT_SUPPORTED,
    InputKindNotPresent = GameInputErrorCodes.GAMEINPUT_E_INPUT_KIND_NOT_PRESENT
}

internal static class GameInputErrorMapper
{
    public static void ThrowIfFailed(int hresult, string context)
    {
        if (HResult.SUCCEEDED(hresult)) return;

        switch ((GameInputError)hresult)
        {
            case GameInputError.DeviceDisconnected:
                throw new GameInputDeviceNotConnectedException(context, hresult);
            case GameInputError.DeviceNotFound:
                throw new GameInputDeviceNotFoundException(context, hresult);
            case GameInputError.ReadingNotFound:
                throw new GameInputReadingNotFoundException(context, hresult);
            case GameInputError.ReferenceReadingTooOld:
                throw new GameInputReferenceReadingTooOldException(context, hresult);
            case GameInputError.FeedbackNotSupported:
                throw new GameInputFeedbackNotSupportedException(context, hresult);
            case GameInputError.ObjectNoLongerExists:
                throw new GameInputObjectNoLongerExistsException(context, hresult);
            case GameInputError.CallbackNotFound:
                throw new GameInputCallbackNotFoundException(context, hresult);
            case GameInputError.HapticInfoNotFound:
                throw new GameInputHapticInfoNotFoundException(context, hresult);
            case GameInputError.AggregateOperationNotSupported:
                throw new GameInputAggregateOperationNotSupportedException(context, hresult);
            case GameInputError.InputKindNotPresent:
                throw new GameInputInputKindNotPresentException(context, hresult);
            default:
                throw new GameInputException(context, hresult);
        }
    }
}

internal class GameInputReadingNotFoundException(string context, int hresult)
    : GameInputException(context, hresult);

public sealed class GameInputDeviceNotConnectedException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputDeviceNotFoundException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputReferenceReadingTooOldException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputFeedbackNotSupportedException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputObjectNoLongerExistsException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputCallbackNotFoundException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputHapticInfoNotFoundException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputAggregateOperationNotSupportedException(string message, int hresult)
    : GameInputException(message, hresult);

public class GameInputInputKindNotPresentException(string message, int hresult)
    : GameInputException(message, hresult);