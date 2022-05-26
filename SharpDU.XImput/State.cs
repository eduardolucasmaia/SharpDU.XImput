using System.Runtime.InteropServices;

namespace SharpDU.XImput
{
    /// <summary>
    /// <p>Represents the state of a controller.</p>
    /// </summary>
    /// <remarks>
    /// <p>The <em>dwPacketNumber</em> member is incremented only if the status of the controller has changed since the controller was last polled. </p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_state</doc-id>
    /// <unmanaged>XINPUT_STATE</unmanaged>
    /// <unmanaged-short>XINPUT_STATE</unmanaged-short>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct State
    {
        /// <summary>
        /// <dd> <p>State packet number. The packet number indicates whether there have been any changes in the state of the controller. If the <em>dwPacketNumber</em> member is the same in sequentially returned <strong><see cref="T:SharpDX.XInput.State" /></strong> structures, the controller state has not changed.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_state</doc-id>
        /// <unmanaged>dwPacketNumber</unmanaged>
        /// <unmanaged-short>dwPacketNumber</unmanaged-short>
        public int PacketNumber;

        /// <summary>
        /// <dd> <p> <strong><see cref="T:SharpDX.XInput.Gamepad" /></strong> structure containing the current state of an Xbox 360 Controller.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_state</doc-id>
        /// <unmanaged>Gamepad</unmanaged>
        /// <unmanaged-short>Gamepad</unmanaged-short>
        public Gamepad Gamepad;
    }
}
