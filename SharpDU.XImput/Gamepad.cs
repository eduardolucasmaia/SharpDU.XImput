﻿using System.Runtime.InteropServices;

namespace SharpDU.XImput
{
    /// <summary>
    /// <p>Describes the current state of the Xbox 360 Controller.</p>
    /// </summary>
    /// <remarks>
    /// <p>This structure is used by the <strong><see cref="T:SharpDX.XInput.State" /></strong> structure when polling for changes in the state of the controller. </p><p>The specific mapping of button to game function varies depending on the game type. </p><p>The constant XINPUT_GAMEPAD_TRIGGER_THRESHOLD may be used as the value which <em>bLeftTrigger</em> and <em>bRightTrigger</em> must be greater than to register as pressed. This is optional, but often desirable. Xbox 360 Controller buttons do not manifest crosstalk.
    /// </p>
    /// </remarks>
    /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
    /// <unmanaged>XINPUT_GAMEPAD</unmanaged>
    /// <unmanaged-short>XINPUT_GAMEPAD</unmanaged-short>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct Gamepad
    {
        /// <summary>Constant TriggerThreshold.</summary>
        /// <unmanaged>XINPUT_GAMEPAD_TRIGGER_THRESHOLD</unmanaged>
        public const byte TriggerThreshold = 30;

        /// <summary>Constant LeftThumbDeadZone</summary>
        /// <unmanaged>XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE</unmanaged>
        public const short LeftThumbDeadZone = 7849;

        /// <summary>Constant RightThumbDeadZone</summary>
        /// <unmanaged>XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE</unmanaged>
        public const short RightThumbDeadZone = 8689;

        /// <summary>
        /// <dd> <p>Bitmask of the device digital buttons, as follows. A set bit indicates that the corresponding button is pressed.  </p> <table> <tr><th>Device button</th><th>Bitmask</th></tr> <tr><td>XINPUT_GAMEPAD_DPAD_UP</td><td> 0x0001</td></tr> <tr><td>XINPUT_GAMEPAD_DPAD_DOWN</td><td> 0x0002</td></tr> <tr><td>XINPUT_GAMEPAD_DPAD_LEFT</td><td> 0x0004</td></tr> <tr><td>XINPUT_GAMEPAD_DPAD_RIGHT</td><td> 0x0008</td></tr> <tr><td>XINPUT_GAMEPAD_START</td><td> 0x0010</td></tr> <tr><td>XINPUT_GAMEPAD_BACK</td><td> 0x0020</td></tr> <tr><td>XINPUT_GAMEPAD_LEFT_THUMB</td><td> 0x0040</td></tr> <tr><td>XINPUT_GAMEPAD_RIGHT_THUMB</td><td> 0x0080</td></tr> <tr><td>XINPUT_GAMEPAD_LEFT_SHOULDER</td><td> 0x0100</td></tr> <tr><td>XINPUT_GAMEPAD_RIGHT_SHOULDER</td><td> 0x0200</td></tr> <tr><td>XINPUT_GAMEPAD_A</td><td> 0x1000</td></tr> <tr><td>XINPUT_GAMEPAD_B</td><td> 0x2000</td></tr> <tr><td>XINPUT_GAMEPAD_X</td><td> 0x4000</td></tr> <tr><td>XINPUT_GAMEPAD_Y</td><td> 0x8000</td></tr> </table> <p>?</p> <p>Bits that are set but not defined above are reserved, and their state is undefined. </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>wButtons</unmanaged>
        /// <unmanaged-short>wButtons</unmanaged-short>
        public GamepadButtonFlags Buttons;

        /// <summary>
        /// <dd> <p>The current value of the left trigger analog control. The value is between 0 and 255.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>bLeftTrigger</unmanaged>
        /// <unmanaged-short>bLeftTrigger</unmanaged-short>
        public byte LeftTrigger;

        /// <summary>
        /// <dd> <p>The current value of the right trigger analog control. The value is between 0 and 255.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>bRightTrigger</unmanaged>
        /// <unmanaged-short>bRightTrigger</unmanaged-short>
        public byte RightTrigger;

        /// <summary>
        /// <dd> <p>Left thumbstick x-axis value. Each of the thumbstick axis members is a signed value between -32768 and 32767 describing the position of the thumbstick. A value of 0 is centered. Negative values signify down or to the left. Positive values signify up or to the right. The constants <see cref="F:SharpDX.XInput.Gamepad.LeftThumbDeadZone" /> or <see cref="F:SharpDX.XInput.Gamepad.RightThumbDeadZone" /> can be used as a positive and negative value to filter a thumbstick input. 
        /// </p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>sThumbLX</unmanaged>
        /// <unmanaged-short>sThumbLX</unmanaged-short>
        public short LeftThumbX;

        /// <summary>
        /// <dd> <p>Left thumbstick y-axis value. The value is between -32768 and 32767.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>sThumbLY</unmanaged>
        /// <unmanaged-short>sThumbLY</unmanaged-short>
        public short LeftThumbY;

        /// <summary>
        /// <dd> <p>Right thumbstick x-axis value. The value is between -32768 and 32767.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>sThumbRX</unmanaged>
        /// <unmanaged-short>sThumbRX</unmanaged-short>
        public short RightThumbX;

        /// <summary>
        /// <dd> <p>Right thumbstick y-axis value. The value is between -32768 and 32767.</p> </dd>
        /// </summary>
        /// <doc-id>microsoft.directx_sdk.reference.xinput_gamepad</doc-id>
        /// <unmanaged>sThumbRY</unmanaged>
        /// <unmanaged-short>sThumbRY</unmanaged-short>
        public short RightThumbY;

        public override string ToString()
        {
            return $"Buttons: {Buttons}, LeftTrigger: {LeftTrigger}, RightTrigger: {RightTrigger}, LeftThumbX: {LeftThumbX}, LeftThumbY: {LeftThumbY}, RightThumbX: {RightThumbX}, RightThumbY: {RightThumbY}";
        }
    }
}
