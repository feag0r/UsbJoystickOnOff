using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UsbJoystickOnOff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Guid deviceGuid = new Guid(GuidTextbox.Text);//("{4D36E96F-E325-11CE-BFC1-08002BE10318}");
            string instancePath = InstanceTextbox.Text;//@"HID\VID_062A&PID_4101&MI_01&COL01\8&14EA75C&0&0000";

            DeviceHelper.SetDeviceEnabled(deviceGuid, instancePath, false); //фалс отключает девайс / тру - включает
        }
    }
}
