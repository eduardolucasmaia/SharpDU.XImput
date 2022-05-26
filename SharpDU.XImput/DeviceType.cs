namespace SharpDU.XImput
{
    /// <summary>
    /// <p>Describes the capabilities of a connected controller. The <strong>XInputGetCapabilities</strong> function returns <strong><see cref="T:SharpDX.XInput.Capabilities" /></strong>. </p>
    /// </summary>
    /// <remarks>
    /// <p> <strong>XInputGetCapabilities</strong> returns <strong><see cref="T:SharpDX.XInput.Capabilities" /></strong> to indicate the characteristics and available functionality of a specified controller. </p><p> <strong>XInputGetCapabilities</strong> sets the structure members to indicate which inputs the device supports. For binary state controls, such as digital buttons, the corresponding bit reflects whether or not the control is supported by the device. For proportional controls, such as thumbsticks, the value indicates the resolution for that control. Some number of the least significant bits may not be set, indicating that the control does not provide resolution to that level. </p><p>The <em>SubType</em> member indicates the specific subtype of controller present. Games may detect the controller subtype and tune their handling of controller input or output based on subtypes that are well suited to their game genre. For example, a car racing game might check for the presence of a wheel controller to provide finer control of the car being driven. However, titles must not disable or ignore a device based on its subtype. Subtypes not recognized by the game or for which the game is not specifically tuned should be treated as a standard Xbox 360 Controller (XINPUT_DEVSUBTYPE_GAMEPAD). </p><p>Older XUSB Windows drivers report incomplete capabilities information, particularly for wireless devices. The latest XUSB Windows driver provides full support for wired and wireless devices, and more complete and accurate capabilties flags. </p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
    /// <unmanaged>XINPUT_DEVTYPE</unmanaged>
    /// <unmanaged-short>XINPUT_DEVTYPE</unmanaged-short>
    public enum DeviceType : byte
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_capabilities</doc-id>
        /// <unmanaged>XINPUT_DEVTYPE_GAMEPAD</unmanaged>
        /// <unmanaged-short>XINPUT_DEVTYPE_GAMEPAD</unmanaged-short>
        Gamepad = 1
    }
}
