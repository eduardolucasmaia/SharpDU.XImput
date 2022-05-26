using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDU.XImput
{
    /// <summary>	
    /// Functions	
    /// </summary>	
    /// <!-- No matching elements were found for the following include tag --><!-- No matching elements were found for the following include tag --><include file="Documentation\CodeComments.xml" path="/comments/comment[@id='SharpDX.XInput.XInput']/*" />	
    internal class XInput13 : IXInput
    {
        private static class Native
        {
            [DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern int XInputGetKeystroke(int dwUserIndex, int dwReserved, out Keystroke keystrokeRef);

            [DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern int XInputGetBatteryInformation(int dwUserIndex, BatteryDeviceType devType, out BatteryInformation batteryInformationRef);

            public unsafe static int XInputSetState(int dwUserIndex, Vibration vibrationRef)
            {
                return XInputSetState_(dwUserIndex, &vibrationRef);
            }

            [DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
            private unsafe static extern int XInputSetState_(int arg0, void* arg1);

            [DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern int XInputGetState(int dwUserIndex, out State stateRef);

            [DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall)]
            public static extern void XInputEnable(RawBool arg0);

            [DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall)]
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
            throw new NotSupportedException("Method not supported on XInput1.3");
        }

        public void XInputEnable(RawBool enable)
        {
            //IL_0000: Unknown result type (might be due to invalid IL or missing references)
            Native.XInputEnable(enable);
        }

        public int XInputGetBatteryInformation(int dwUserIndex, BatteryDeviceType devType, out BatteryInformation batteryInformationRef)
        {
            return Native.XInputGetBatteryInformation(dwUserIndex, devType, out batteryInformationRef);
        }

        public int XInputGetKeystroke(int dwUserIndex, int dwReserved, out Keystroke keystrokeRef)
        {
            return Native.XInputGetKeystroke(dwUserIndex, dwReserved, out keystrokeRef);
        }

        public int XInputGetCapabilities(int dwUserIndex, DeviceQueryType dwFlags, out Capabilities capabilitiesRef)
        {
            return Native.XInputGetCapabilities(dwUserIndex, dwFlags, out capabilitiesRef);
        }
    }
}
