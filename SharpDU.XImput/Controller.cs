using System;
using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Mathematics.Interop;
using SharpDX.Win32;

namespace SharpDU.XImput
{
    /// <summary>
    /// A XInput controller.
    /// </summary>
    public class Controller
    {
        private readonly UserIndex userIndex;

        private static readonly IXInput xinput;

        /// <summary>
        /// Gets the <see cref="P:SharpDX.XInput.Controller.UserIndex" /> associated with this controller.
        /// </summary>
        /// <value>The index of the user.</value>
        public UserIndex UserIndex => userIndex;

        /// <summary>
        /// Gets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        public bool IsConnected
        {
            get
            {
                State temp;
                return xinput.XInputGetState((int)userIndex, out temp) == 0;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SharpDX.XInput.Controller" /> class.
        /// </summary>
        /// <param name="userIndex">Index of the user.</param>
        public Controller(UserIndex userIndex = UserIndex.Any)
        {
            if (xinput == null)
            {
                throw new NotSupportedException("XInput 1.4 or 1.3 or 9.1.0 is not installed");
            }
            this.userIndex = userIndex;
        }

        /// <summary>
        /// Gets the battery information.
        /// </summary>
        /// <param name="batteryDeviceType">Type of the battery device.</param>
        /// <returns></returns>
        /// <unmanaged>unsigned int XInputGetBatteryInformation([In] XUSER_INDEX dwUserIndex,[In] BATTERY_DEVTYPE devType,[Out] XINPUT_BATTERY_INFORMATION* pBatteryInformation)</unmanaged>	
        public BatteryInformation GetBatteryInformation(BatteryDeviceType batteryDeviceType)
        {
            //IL_0013: Unknown result type (might be due to invalid IL or missing references)
            //IL_0018: Unknown result type (might be due to invalid IL or missing references)
            BatteryInformation temp;
            Result result = ErrorCodeHelper.ToResult(xinput.XInputGetBatteryInformation((int)userIndex, batteryDeviceType, out temp));
            //((Result)(ref result)).CheckError();
            ((Result)(result)).CheckError();
            return temp;
        }

        /// <summary>
        /// Gets the capabilities.
        /// </summary>
        /// <param name="deviceQueryType">Type of the device query.</param>
        /// <returns></returns>
        /// <unmanaged>unsigned int XInputGetCapabilities([In] XUSER_INDEX dwUserIndex,[In] XINPUT_DEVQUERYTYPE dwFlags,[Out] XINPUT_CAPABILITIES* pCapabilities)</unmanaged>	
        public Capabilities GetCapabilities(DeviceQueryType deviceQueryType)
        {
            //IL_0013: Unknown result type (might be due to invalid IL or missing references)
            //IL_0018: Unknown result type (might be due to invalid IL or missing references)
            Capabilities temp;
            Result result = ErrorCodeHelper.ToResult(xinput.XInputGetCapabilities((int)userIndex, deviceQueryType, out temp));
            //((Result)(ref result)).CheckError();
            ((Result)(result)).CheckError();
            return temp;
        }

        /// <summary>
        /// Gets the capabilities.
        /// </summary>
        /// <param name="deviceQueryType">Type of the device query.</param>
        /// <param name="capabilities">The capabilities of this controller.</param>
        /// <returns><c>true</c> if the controller is connected, <c>false</c> otherwise.</returns>
        public bool GetCapabilities(DeviceQueryType deviceQueryType, out Capabilities capabilities)
        {
            return xinput.XInputGetCapabilities((int)userIndex, deviceQueryType, out capabilities) == 0;
        }

        /// <summary>
        /// Gets the keystroke.
        /// </summary>
        /// <param name="deviceQueryType">The flag.</param>
        /// <param name="keystroke">The keystroke.</param>
        /// <returns></returns>
        /// <unmanaged>unsigned int XInputGetKeystroke([In] XUSER_INDEX dwUserIndex,[In] unsigned int dwReserved,[Out] XINPUT_KEYSTROKE* pKeystroke)</unmanaged>	
        public Result GetKeystroke(DeviceQueryType deviceQueryType, out Keystroke keystroke)
        {
            //IL_0012: Unknown result type (might be due to invalid IL or missing references)
            return ErrorCodeHelper.ToResult(xinput.XInputGetKeystroke((int)userIndex, (int)deviceQueryType, out keystroke));
        }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <returns>The state of this controller.</returns>
        public State GetState()
        {
            //IL_0012: Unknown result type (might be due to invalid IL or missing references)
            //IL_0017: Unknown result type (might be due to invalid IL or missing references)
            State temp;
            Result result = ErrorCodeHelper.ToResult(xinput.XInputGetState((int)userIndex, out temp));
            //((Result)(ref result)).CheckError();
            ((Result)(result)).CheckError();
            return temp;
        }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <param name="state">The state of this controller.</param>
        /// <returns><c>true</c> if the controller is connected, <c>false</c> otherwise.</returns>
        public bool GetState(out State state)
        {
            return xinput.XInputGetState((int)userIndex, out state) == 0;
        }

        /// <summary>
        /// Sets the reporting.
        /// </summary>
        /// <param name="enableReporting">if set to <c>true</c> [enable reporting].</param>
        public static void SetReporting(bool enableReporting)
        {
            //IL_000d: Unknown result type (might be due to invalid IL or missing references)
            if (xinput != null)
            {
                //xinput.XInputEnable(RawBool.op_Implicit(enableReporting));
            }
        }

        /// <summary>
        /// Sets the vibration.
        /// </summary>
        /// <param name="vibration">The vibration.</param>
        /// <returns></returns>
        public Result SetVibration(Vibration vibration)
        {
            //IL_0011: Unknown result type (might be due to invalid IL or missing references)
            //IL_0016: Unknown result type (might be due to invalid IL or missing references)
            //IL_001e: Unknown result type (might be due to invalid IL or missing references)
            Result result = ErrorCodeHelper.ToResult(xinput.XInputSetState((int)userIndex, vibration));
            //((Result)(ref result)).CheckError();
            ((Result)(result)).CheckError();
            return result;
        }

        static Controller()
        {
            if (LoadLibrary("xinput1_4.dll") != IntPtr.Zero)
            {
                xinput = new XInput14();
            }
            else if (LoadLibrary("xinput1_3.dll") != IntPtr.Zero)
            {
                xinput = new XInput13();
            }
            else if (LoadLibrary("xinput9_1_0.dll") != IntPtr.Zero)
            {
                xinput = new XInput910();
            }
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string lpFileName);
    }
}
