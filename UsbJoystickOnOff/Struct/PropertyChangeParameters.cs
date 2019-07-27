using System.Runtime.InteropServices;
using UsbJoystickOnOff.Enum;

namespace UsbJoystickOnOff.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PropertyChangeParameters
    {
        public int Size;
        // part of header. It's flattened out into 1 structure.
        public DiFunction DiFunction;
        public StateChangeAction StateChange;
        public Scopes Scope;
        public int HwProfile;
    }
}
