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
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;

namespace senior_design_application.Classes
{
    public static class Background
    {
        static SerialPort sp;
        static int Count = 0;
        public static void PortSetup(string port)
        {
            sp = new SerialPort();
            sp.PortName = port;
            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.DataBits = 8;
            sp.Handshake = Handshake.None;
            sp.RtsEnable = true;
        }

        public static void SendMessage(string message)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            if(sp != null)
            {
                if(sp.IsOpen)
                {
                    sp.WriteLine(message);
                }
                else
                {
                    sp.Open();
                    sp.ReadTimeout = 1000;
                    sp.WriteLine(message);
                }
            }
            else
            {
                if(sp.IsOpen)
                {
                    MessageBox.Show("Port is already open");
                }
                else
                {
                    MessageBox.Show("port == null");
                }
            }
        }
        public static void OnApplicationQuit()
        {
            sp.Close();
        }

        public static int countHandler(int value)
        {
            if (value == 1)
            {
                Count = Count + 1;
            }
            else if (value == -1)
            {
                Count = Count - 1;
            }
            else if (value == 0)
            {
                Count = 0;
            }

            if (Count > 3)
            {
                Count = 4;
            }
            if (Count < -3)
            {
                Count = -3;
            }
            return Count;
        }

        public static void sendIndex()
        {
            SendMessage(Count.ToString());
        }
    }
}