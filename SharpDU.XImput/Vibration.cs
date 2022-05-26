using System.Runtime.InteropServices;

namespace SharpDU.XImput
{
    /// <summary>
    /// <p>Specifies motor speed levels for the vibration function of a controller.</p>
    /// </summary>
    /// <remarks>
    /// <p>The left motor is the low-frequency rumble motor. The right motor is the high-frequency rumble motor. The two motors are not the same, and they create different vibration effects.</p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_vibration</doc-id>
    /// <unmanaged>XINPUT_VIBRATION</unmanaged>
    /// <unmanaged-short>XINPUT_VIBRATION</unmanaged-short>
    public struct Vibration
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct __Native
        {
            public short LeftMotorSpeed;

            public short RightMotorSpeed;
        }

        /// <summary>
        /// <dd> <p>Speed of the left motor. Valid values are in the range 0 to 65,535. Zero signifies no motor use; 65,535 signifies 100 percent motor use.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_vibration</doc-id>
        /// <unmanaged>wLeftMotorSpeed</unmanaged>
        /// <unmanaged-short>wLeftMotorSpeed</unmanaged-short>
        public ushort LeftMotorSpeed;

        /// <summary>
        /// <dd> <p>Speed of the right motor. Valid values are in the range 0 to 65,535. Zero signifies no motor use; 65,535 signifies 100 percent motor use.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_vibration</doc-id>
        /// <unmanaged>wRightMotorSpeed</unmanaged>
        /// <unmanaged-short>wRightMotorSpeed</unmanaged-short>
        public ushort RightMotorSpeed;

        internal void __MarshalFree(ref __Native @ref)
        {
        }

        internal void __MarshalFrom(ref __Native @ref)
        {
            LeftMotorSpeed = (ushort)@ref.LeftMotorSpeed;
            RightMotorSpeed = (ushort)@ref.RightMotorSpeed;
        }

        internal void __MarshalTo(ref __Native @ref)
        {
            @ref.LeftMotorSpeed = (short)LeftMotorSpeed;
            @ref.RightMotorSpeed = (short)RightMotorSpeed;
        }
    }
}
