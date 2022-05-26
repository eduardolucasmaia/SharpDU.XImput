using System;

namespace SharpDU.XImput
{
    [Flags]
    public enum KeyStrokeFlags : short
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_KEYSTROKE_KEYDOWN</unmanaged>
        /// <unmanaged-short>XINPUT_KEYSTROKE_KEYDOWN</unmanaged-short>
        KeyDown = 0x1,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_KEYSTROKE_KEYUP</unmanaged>
        /// <unmanaged-short>XINPUT_KEYSTROKE_KEYUP</unmanaged-short>
        KeyUp = 0x2,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_KEYSTROKE_REPEAT</unmanaged>
        /// <unmanaged-short>XINPUT_KEYSTROKE_REPEAT</unmanaged-short>
        Repeat = 0x4,
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = 0x0
    }
}
