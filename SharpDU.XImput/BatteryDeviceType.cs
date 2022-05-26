namespace SharpDU.XImput
{
    /// <summary>
    /// <p>Retrieves the battery type and charge status of a wireless controller.</p>
    /// </summary>
    /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
    /// <unmanaged>BATTERY_DEVTYPE</unmanaged>
    /// <unmanaged-short>BATTERY_DEVTYPE</unmanaged-short>
    public enum BatteryDeviceType
    {
        /// <summary>
        /// <dd> <p>Index of the signed-in gamer associated with the device. Can be a value in the range 0?XUSER_MAX_COUNT ? 1.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
        /// <unmanaged>BATTERY_DEVTYPE_GAMEPAD</unmanaged>
        /// <unmanaged-short>BATTERY_DEVTYPE_GAMEPAD</unmanaged-short>
        Gamepad,
        /// <summary>
        /// <dd> <p>Specifies which device associated with this user index should be queried. Must be <strong>BATTERY_DEVTYPE_GAMEPAD</strong> or <strong>BATTERY_DEVTYPE_HEADSET</strong>.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinputgetbatteryinformation</doc-id>
        /// <unmanaged>BATTERY_DEVTYPE_HEADSET</unmanaged>
        /// <unmanaged-short>BATTERY_DEVTYPE_HEADSET</unmanaged-short>
        Headset
    }
}
