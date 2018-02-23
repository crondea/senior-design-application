using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;

namespace senior_design_application.Classes
{
    public class Background
    {

        //public Background()
        //{
        //    const int MAX_MESSAGE_SIZE = 128;
        //    const int MAX_ATTEMPTS = 3;
        //}

        public static bool connectAsClient()
        {
            BluetoothClient client = new BluetoothClient();
            MessageBox.Show("Attempting to connect as client.");

            
            return false;
        }

    }

}