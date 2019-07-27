using System;

namespace UsbJoystickOnOff.Enum
{
    [Flags()]
    internal enum Scopes
    {
        Global = 1,
        ConfigSpecific = 2,
        ConfigGeneral = 4
    }
}
