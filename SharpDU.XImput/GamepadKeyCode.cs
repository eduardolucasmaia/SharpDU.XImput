using System;

namespace SharpDU.XImput
{
    [Flags]
    public enum GamepadKeyCode : short
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_A</unmanaged>
        /// <unmanaged-short>VK_PAD_A</unmanaged-short>
        A = 0x5800,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_B</unmanaged>
        /// <unmanaged-short>VK_PAD_B</unmanaged-short>
        B = 0x5801,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_X</unmanaged>
        /// <unmanaged-short>VK_PAD_X</unmanaged-short>
        X = 0x5802,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_Y</unmanaged>
        /// <unmanaged-short>VK_PAD_Y</unmanaged-short>
        Y = 0x5803,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RSHOULDER</unmanaged>
        /// <unmanaged-short>VK_PAD_RSHOULDER</unmanaged-short>
        RightShoulder = 0x5804,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LSHOULDER</unmanaged>
        /// <unmanaged-short>VK_PAD_LSHOULDER</unmanaged-short>
        LeftShoulder = 0x5805,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTRIGGER</unmanaged>
        /// <unmanaged-short>VK_PAD_LTRIGGER</unmanaged-short>
        LeftTrigger = 0x5806,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTRIGGER</unmanaged>
        /// <unmanaged-short>VK_PAD_RTRIGGER</unmanaged-short>
        RightTrigger = 0x5807,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_UP</unmanaged-short>
        DPadUp = 0x5810,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_DOWN</unmanaged-short>
        DPadDown = 0x5811,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_LEFT</unmanaged-short>
        DPadLeft = 0x5812,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_DPAD_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_DPAD_RIGHT</unmanaged-short>
        DPadRight = 0x5813,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_START</unmanaged>
        /// <unmanaged-short>VK_PAD_START</unmanaged-short>
        Start = 0x5814,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_BACK</unmanaged>
        /// <unmanaged-short>VK_PAD_BACK</unmanaged-short>
        Back = 0x5815,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_PRESS</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_PRESS</unmanaged-short>
        LeftThumbPress = 0x5816,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_PRESS</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_PRESS</unmanaged-short>
        RightThumbPress = 0x5817,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UP</unmanaged-short>
        LeftThumbUp = 0x5820,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWN</unmanaged-short>
        LeftThumbDown = 0x5821,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_RIGHT</unmanaged-short>
        LeftThumbRight = 0x5822,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_LEFT</unmanaged-short>
        LeftThumbLeft = 0x5823,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_UPLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UPLEFT</unmanaged-short>
        RightThumbUpLeft = 0x5824,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_UPRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_UPRIGHT</unmanaged-short>
        LeftThumbUpright = 0x5825,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWNRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWNRIGHT</unmanaged-short>
        LeftThumbDownright = 0x5826,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_LTHUMB_DOWNLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_LTHUMB_DOWNLEFT</unmanaged-short>
        RightThumbDownLeft = 0x5827,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_UP</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UP</unmanaged-short>
        RightThumbUp = 0x5830,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWN</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWN</unmanaged-short>
        RightThumbDown = 0x5831,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_RIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_RIGHT</unmanaged-short>
        RightThumbRight = 0x5832,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_LEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_LEFT</unmanaged-short>
        RightThumbLeft = 0x5833,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_UPLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UPLEFT</unmanaged-short>
        RightThumbUpleft = 0x5834,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_UPRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_UPRIGHT</unmanaged-short>
        RightThumbUpRight = 0x5835,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWNRIGHT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWNRIGHT</unmanaged-short>
        RightThumbDownRight = 0x5836,
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>VK_PAD_RTHUMB_DOWNLEFT</unmanaged>
        /// <unmanaged-short>VK_PAD_RTHUMB_DOWNLEFT</unmanaged-short>
        RightThumbDownleft = 0x5837,
        /// <summary>
        /// None
        /// </summary>
        /// <unmanaged>None</unmanaged>
        /// <unmanaged-short>None</unmanaged-short>
        None = 0x0
    }
}
