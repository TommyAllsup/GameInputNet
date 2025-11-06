using System.Runtime.InteropServices;

namespace GameInputNet.Interop;

public static class GameInputNative
{
    [UnmanagedFunctionPointer(CallbackConvention)]
    public unsafe delegate void GameInputDeviceCallback(ulong callbackToken, void* context,
        [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp,
        GameInputDeviceStatus currentStatus, GameInputDeviceStatus
            previousStatus);

    [UnmanagedFunctionPointer(CallbackConvention)]
    public unsafe delegate void GameInputKeyboardLayoutCallback(ulong callbackToken, void* context,
        [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp, uint currentLayout, uint
            previousLayout);

    [UnmanagedFunctionPointer(CallbackConvention)]
    public unsafe delegate void GameInputReadingCallback(ulong callbackToken, void* context,
        [MarshalAs(UnmanagedType.Interface)] IGameInputReading reading);

    [UnmanagedFunctionPointer(CallbackConvention)]
    public unsafe delegate void GameInputSystemButtonCallback(ulong callbackToken, void* context,
        [MarshalAs(UnmanagedType.Interface)] IGameInputDevice device, ulong timestamp,
        GameInputSystemButtons currentButtons, GameInputSystemButtons
            previousButtons);

    private const CallingConvention CallbackConvention = CallingConvention.StdCall;

    private const string GameInputDll = "GameInput.dll";

    [DllImport(GameInputDll, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern int GameInputCreate(out IGameInput? gameInput);


    [ComImport]
    [Guid("20EFC1C7-5D9A-43BA-B26F-B807FA48609C")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInput
    {
        [PreserveSig]
        ulong GetCurrentTimestamp();

        [PreserveSig]
        int GetCurrentReading(GameInputKind inputKind, [MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
            out IGameInputReading? reading);

        [PreserveSig]
        int GetNextReading([MarshalAs(UnmanagedType.Interface)] IGameInputReading referenceReading,
            GameInputKind inputKind,
            [MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device, out IGameInputReading? reading);

        [PreserveSig]
        int GetPreviousReading([MarshalAs(UnmanagedType.Interface)] IGameInputReading referenceReading, GameInputKind
            inputKind, [MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device, out IGameInputReading? reading);

        [PreserveSig]
        unsafe int RegisterReadingCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
            GameInputKind inputKind,
            void* context, GameInputReadingCallback callback, out ulong callbackToken);

        [PreserveSig]
        unsafe int RegisterDeviceCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
            GameInputKind inputKind, uint statusFilter, GameInputEnumerationKind enumerationKind, void* context,
            GameInputDeviceCallback callback, out ulong callbackToken);

        [PreserveSig]
        unsafe int RegisterSystemButtonCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
            GameInputSystemButtons buttonFilter, void* context, GameInputSystemButtonCallback callback,
            out ulong callbackToken);

        [PreserveSig]
        unsafe int RegisterKeyboardLayoutCallback([MarshalAs(UnmanagedType.Interface)] IGameInputDevice? device,
            void* context, GameInputKeyboardLayoutCallback callback, out ulong callbackToken);

        [PreserveSig]
        void StopCallback(ulong callbackToken);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool UnregisterCallback(ulong callbackToken);

        [PreserveSig]
        int CreateDispatcher(out IGameInputDispatcher? dispatcher);

        [PreserveSig]
        unsafe int FindDeviceFromId(AppLocalDeviceId* deviceId, out IGameInputDevice? device);

        [PreserveSig]
        int FindDeviceFromPlatformString([MarshalAs(UnmanagedType.LPWStr)] string value, out IGameInputDevice?
            device);

        [PreserveSig]
        void SetFocusPolicy(GameInputFocusPolicy policy);

        [PreserveSig]
        unsafe int CreateAggregateDevice(GameInputKind inputKind, AppLocalDeviceId* deviceId);

        [PreserveSig]
        unsafe int DisableAggregateDevice(AppLocalDeviceId* deviceId);
    }

    [ComImport]
    [Guid("05A42D89-2CB6-45A3-874D-E635723587AB")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInputRawDeviceReport
    {
        [PreserveSig]
        void GetDevice(out IGameInputDevice? device);

        [PreserveSig]
        void GetReportInfo(out GameInputRawDeviceReportInfo reportInfo);

        [PreserveSig]
        nuint GetRawDataSize();

        [PreserveSig]
        unsafe nuint GetRawData(nuint bufferSize, void* buffer);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool SetRawData(nuint bufferSize, void* buffer);
    }

    [ComImport]
    [Guid("C81C4CDE-ED1A-4631-A30F-C556A6241A1F")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInputReading
    {
        [PreserveSig]
        GameInputKind GetInputKind();

        [PreserveSig]
        ulong GetTimestamp();

        [PreserveSig]
        void GetDevice([MarshalAs(UnmanagedType.Interface)] out IGameInputDevice? device);

        [PreserveSig]
        uint GetControllerAxisCount();

        [PreserveSig]
        unsafe uint GetControllerAxisState(uint stateArrayCount, float* stateArray);

        [PreserveSig]
        uint GetControllerButtonCount();

        [PreserveSig]
        unsafe uint GetControllerButtonState(uint stateArrayCount, bool* stateArray);

        [PreserveSig]
        uint GetControllerSwitchCount();

        [PreserveSig]
        unsafe uint GetControllerSwitchState(uint stateArrayCount, GameInputSwitchPosition* stateArray);

        [PreserveSig]
        uint GetKeyCount();

        [PreserveSig]
        unsafe uint GetKeyState(uint stateArrayCount, GameInputKeyState* stateArray);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetMouseState(GameInputMouseState* state);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetSensorsState(GameInputSensorsState* state);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetArcadeStickState(GameInputArcadeStickState* state);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetFlightStickState(GameInputFlightStickState* state);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetGamepadState(GameInputGamepadState* state);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetRacingWheelState(GameInputRacingWheelState* state);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetRawReport(out IGameInputRawDeviceReport? report);
    }

    [ComImport]
    [Guid("63E2F38B-A399-4275-8AE7-D4C6E524D12A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInputDevice
    {
        [PreserveSig]
        unsafe int GetDeviceInfo(out GameInputDeviceInfo* info);

        [PreserveSig]
        unsafe int GetHapticInfo(GameInputHapticInfo* info);

        [PreserveSig]
        GameInputDeviceStatus GetDeviceStatus();

        [PreserveSig]
        unsafe int CreateForceFeedbackEffect(uint motorIndex, GameInputForceFeedbackParams* @params,
            out IGameInputForceFeedbackEffect? effect);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool IsForceFeedbackMotorPoweredOn(uint motorIndex);

        [PreserveSig]
        void SetForceFeedbackMotorGain(uint motorIndex, float masterGain);

        [PreserveSig]
        unsafe void SetRumbleState(GameInputRumbleParams* @params);

        [PreserveSig]
        unsafe int DirectInputEscape(uint command, void* bufferIn, uint bufferInSize, void* bufferOut,
            uint bufferOutSize, uint* bufferOutSizeWritten);

        [PreserveSig]
        int CreateInputMapper(out IGameInputMapper? inputMapper);

        [PreserveSig]
        unsafe int GetExtraAxisCount(GameInputKind inputKind, uint* extraAxisCount);

        [PreserveSig]
        unsafe int GetExtraButtonCount(GameInputKind inputKind, uint* extraButtonCount);

        [PreserveSig]
        unsafe int GetExtraAxisIndexes(GameInputKind inputKind, uint extraAxisCount, byte* extraAxisIndexes);

        [PreserveSig]
        unsafe int GetExtraButtonIndexes(GameInputKind inputKind, uint extraButtonCount, byte* extraButtonIndexes);

        [PreserveSig]
        int CreateRawDeviceReport(uint reportId, GameInputRawDeviceReportKind reportKind,
            out IGameInputRawDeviceReport? report);

        [PreserveSig]
        int SendRawDeviceOutput([MarshalAs(UnmanagedType.Interface)] IGameInputRawDeviceReport report);
    }

    [ComImport]
    [Guid("415EED2E-98CB-42C2-8F28-B94601074E31")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInputDispatcher
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool Dispatch(ulong quotaInMicroseconds);

        [PreserveSig]
        int OpenWaitHandle(out IntPtr waitHandle);
    }

    [ComImport]
    [Guid("FF61096A-3373-4093-A1DF-6D31846B3511")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInputForceFeedbackEffect
    {
        [PreserveSig]
        void GetDevice(out IGameInputDevice? device);

        [PreserveSig]
        uint GetMotorIndex();

        [PreserveSig]
        float GetGain();

        [PreserveSig]
        void SetGain(float gain);

        [PreserveSig]
        unsafe void GetParams(GameInputForceFeedbackParams* @params);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool SetParams(GameInputForceFeedbackParams* @params);

        [PreserveSig]
        GameInputFeedbackEffectState GetState();

        [PreserveSig]
        void SetState(GameInputFeedbackEffectState state);
    }

    [ComImport]
    [Guid("3C600700-F16C-49CE-9BE6-6A2EF752ED5E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGameInputMapper
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetArcadeStickButtonMappingInfo(GameInputArcadeStickButtons buttonElement,
            GameInputButtonMapping* mapping);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetFlightStickAxisMappingInfo(GameInputFlightStickAxes axisElement,
            GameInputAxisMapping* mapping);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetFlightStickButtonMappingInfo(GameInputFlightStickButtons buttonElement,
            GameInputButtonMapping* mapping);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetGamepadAxisMappingInfo(GameInputGamepadAxes axisElement, GameInputAxisMapping* mapping);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetGamepadButtonMappingInfo(GameInputGamepadButtons buttonElement,
            GameInputButtonMapping* mapping);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetRacingWheelAxisMappingInfo(GameInputRacingWheelAxes axisElement,
            GameInputAxisMapping* mapping);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        unsafe bool GetRacingWheelButtonMappingInfo(GameInputRacingWheelButtons buttonElement,
            GameInputButtonMapping* mapping);
    }
}