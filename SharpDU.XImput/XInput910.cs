using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDU.XImput
{
    internal class XInput910 : IXInput
    {
        private static class Native
        {
            public unsafe static int XInputSetState(int dwUserIndex, Vibration vibrationRef)
            {
                return XInputSetState_(dwUserIndex, &vibrationRef);
            }

            [DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
            private unsafe static extern int XInputSetState_(int arg0, void* arg1);

            [DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern int XInputGetState(int dwUserIndex, out State stateRef);

            [DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern int XInputGetCapabilities(int dwUserIndex, DeviceQueryType dwFlags, out Capabilities capabilitiesRef);
        }

        public int XInputSetState(int dwUserIndex, Vibration vibrationRef)
        {
            return Native.XInputSetState(dwUserIndex, vibrationRef);
        }

        public int XInputGetState(int dwUserIndex, out State stateRef)
        {
            return Native.XInputGetState(dwUserIndex, out stateRef);
        }

        public int XInputGetAudioDeviceIds(int dwUserIndex, IntPtr renderDeviceIdRef, IntPtr renderCountRef, IntPtr captureDeviceIdRef, IntPtr captureCountRef)
        {
            throw new NotSupportedException("Method not supported on XInput9.1.0");
        }

        public void XInputEnable(RawBool enable)
        {
            throw new NotSupportedException("Method not supported on XInput9.1.0");
        }

        public int XInputGetBatteryInformation(int dwUserIndex, BatteryDeviceType devType, out BatteryInformation batteryInformationRef)
        {
            throw new NotSupportedException("Method not supported on XInput9.1.0");
        }

        public int XInputGetKeystroke(int dwUserIndex, int dwReserved, out Keystroke keystrokeRef)
        {
            throw new NotSupportedException("Method not supported on XInput9.1.0");
        }

        public int XInputGetCapabilities(int dwUserIndex, DeviceQueryType dwFlags, out Capabilities capabilitiesRef)
        {
            return Native.XInputGetCapabilities(dwUserIndex, dwFlags, out capabilitiesRef);
        }
    }

}
