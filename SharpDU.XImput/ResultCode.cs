using SharpDX;
using SharpDX.Win32;

namespace SharpDU.XImput
{
    /// <summary>
    /// Common error code from XInput
    /// </summary>
    public sealed class ResultCode
    {
        /// <summary>
        /// Device is not connected
        /// </summary>
        public static readonly Result NotConnected = ErrorCodeHelper.ToResult((ErrorCode)1167);
    }
}
