namespace SharpDU.XImput
{
    /// <summary>
    /// <p>Retrieves a gamepad input event.</p>
    /// </summary>
    /// <remarks>
    /// <p>Wireless controllers are not considered active upon system startup, and calls to any of the <em>XInput</em> functions before a wireless controller is made active return <strong>ERROR_DEVICE_NOT_CONNECTED</strong>. Game titles must examine the return code and be prepared to handle this condition. Wired controllers are automatically activated when they are inserted. Wireless controllers are activated when the user presses the START or Xbox Guide button to power on the controller.</p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
    /// <unmanaged>XUSER_INDEX</unmanaged>
    /// <unmanaged-short>XUSER_INDEX</unmanaged-short>
    public enum UserIndex : byte
    {
        /// <summary>
        /// <dd> <p>[in] Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1, or XUSER_INDEX_ANY to fetch the next available input event from any user.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_ANY</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_ANY</unmanaged-short>
        Any = byte.MaxValue,
        /// <summary>
        /// <dd> <p>[in] Reserved</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_ONE</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_ONE</unmanaged-short>
        One = 0,
        /// <summary>
        /// <dd> <p>[out] Pointer to an <strong><see cref="T:SharpDX.XInput.Keystroke" /></strong> structure that receives an input event.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_TWO</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_TWO</unmanaged-short>
        Two = 1,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_THREE</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_THREE</unmanaged-short>
        Three = 2,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetkeystroke</doc-id>
        /// <unmanaged>XUSER_INDEX_FOUR</unmanaged>
        /// <unmanaged-short>XUSER_INDEX_FOUR</unmanaged-short>
        Four = 3
    }
}
