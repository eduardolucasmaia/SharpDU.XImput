using System;

namespace SharpDU.XImput
{
    [Flags]
    public enum GamepadButtonFlags : ushort
    {
        None = 0x0,
        DPadUp = 0x1,
        DPadDown = 0x2,
        DPadLeft = 0x4,
        DPadRight = 0x8,
        Start = 0x10,
        Back = 0x20,
        LeftThumb = 0x40,
        RightThumb = 0x80,
        LeftShoulder = 0x100,
        RightShoulder = 0x200,
        A = 0x1000,
        B = 0x2000,
        X = 0x4000,
        Y = 0x8000
    }
}
