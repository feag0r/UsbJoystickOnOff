using System;
using System.Runtime.InteropServices;

namespace UsbJoystickOnOff.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct DeviceInfoData
    {
        public int Size;
        public Guid ClassGuid;
        public int DevInst;
        public IntPtr Reserved;
    }
}
