using System;

namespace SharpDU.XImput
{
    [Flags]
    public enum CapabilityFlags : short
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_VOICE_SUPPORTED</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_VOICE_SUPPORTED</unmanaged-short>
        VoiceSupported = 0x4,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_FFB_SUPPORTED</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_FFB_SUPPORTED</unmanaged-short>
        FfbSupported = 0x1,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_WIRELESS</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_WIRELESS</unmanaged-short>
        Wireless = 0x2,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_PMD_SUPPORTED</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_PMD_SUPPORTED</unmanaged-short>
        PmdSupported = 0x8,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>XINPUT_CAPS_NO_NAVIGATION</unmanaged>
        /// <unmanaged-short>XINPUT_CAPS_NO_NAVIGATION</unmanaged-short>
        NoNavigation = 0x10,
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = 0x0
    }
}
