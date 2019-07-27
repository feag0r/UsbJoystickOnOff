using System;

namespace UsbJoystickOnOff.Enum
{
    [Flags()]
    internal enum SetupDiGetClassDevsFlags
    {
        Default = 1,
        Present = 2,
        AllClasses = 4,
        Profile = 8,
        DeviceInterface = (int)0x10
    }
}
