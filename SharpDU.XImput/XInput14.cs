using System;
using SharpDX.Mathematics.Interop;

namespace SharpDU.XImput
{
    internal class XInput14 : IXInput
    {
        public int XInputSetState(int dwUserIndex, Vibration vibrationRef)
        {
            return XInput.XInputSetState(dwUserIndex, ref vibrationRef);
        }

        public int XInputGetState(int dwUserIndex, out State stateRef)
        {
            return XInput.XInputGetState(dwUserIndex, out stateRef);
        }

        public int XInputGetAudioDeviceIds(int dwUserIndex, IntPtr renderDeviceIdRef, IntPtr renderCountRef, IntPtr captureDeviceIdRef, IntPtr captureCountRef)
        {
            return XInput.XInputGetAudioDeviceIds(dwUserIndex, renderDeviceIdRef, renderCountRef, captureDeviceIdRef, captureCountRef);
        }

        public void XInputEnable(RawBool enable)
        {
            //IL_0000: Unknown result type (might be due to invalid IL or missing references)
            XInput.XInputEnable(enable);
        }

        public int XInputGetBatteryInformation(int dwUserIndex, BatteryDeviceType devType, out BatteryInformation batteryInformationRef)
        {
            return XInput.XInputGetBatteryInformation(dwUserIndex, devType, out batteryInformationRef);
        }

        public int XInputGetKeystroke(int dwUserIndex, int dwReserved, out Keystroke keystrokeRef)
        {
            return XInput.XInputGetKeystroke(dwUserIndex, dwReserved, out keystrokeRef);
        }

        public int XInputGetCapabilities(int dwUserIndex, DeviceQueryType dwFlags, out Capabilities capabilitiesRef)
        {
            return XInput.XInputGetCapabilities(dwUserIndex, dwFlags, out capabilitiesRef);
        }
    }
}
