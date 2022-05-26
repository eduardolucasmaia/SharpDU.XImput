using System;
using SharpDX.Mathematics.Interop;

namespace SharpDU.XImput
{
    /// <summary>
    /// Common interface for XInput to allow using XInput 1.4, 1.3 or 9.1.0.
    /// </summary>
    internal interface IXInput
    {
        int XInputSetState(int dwUserIndex, Vibration vibrationRef);

        int XInputGetState(int dwUserIndex, out State stateRef);

        int XInputGetAudioDeviceIds(int dwUserIndex, IntPtr renderDeviceIdRef, IntPtr renderCountRef, IntPtr captureDeviceIdRef, IntPtr captureCountRef);

        void XInputEnable(RawBool enable);

        int XInputGetBatteryInformation(int dwUserIndex, BatteryDeviceType devType, out BatteryInformation batteryInformationRef);

        int XInputGetKeystroke(int dwUserIndex, int dwReserved, out Keystroke keystrokeRef);

        int XInputGetCapabilities(int dwUserIndex, DeviceQueryType dwFlags, out Capabilities capabilitiesRef);
    }
}
