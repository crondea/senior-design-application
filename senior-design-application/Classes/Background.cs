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

        //public Background()
        //{
        //    const int MAX_MESSAGE_SIZE = 128;
        //    const int MAX_ATTEMPTS = 3;
        //}

        //public static bool connectAsClient()
        //{
        //    BluetoothClient client = new BluetoothClient();
        //    MessageBox.Show("Attempting to connect as client.");


        //    return false;
        //}

        //private const int defaultPort = 51001;

        //public static void SendMessage(string message)
        //{
        //    IPAddress broadcast = IPAddress.Parse("192.168.0.4");
        //    byte[] sendbuff = Encoding.ASCII.GetBytes(message);
        //    IPEndPoint ep = new IPEndPoint(broadcast, defaultPort);
        //    UdpClient client = new UdpClient();
        //    int test = 5;
        //    byte[] dgram = Encoding.ASCII.GetBytes(test.ToString().ToCharArray());
        //    //MessageBox.Show(Convert.ToInt32(dgram).ToString());
        //    int i;
        //    for (i = 0; i < 5; i++)
        //    {
        //        client.Send(sendbuff, dgram.Length, ep);
        //        Thread.Sleep(500);
        //    }
        //}

        static SerialPort sp = new SerialPort("COM4");

        public static void SendMessage(string message)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.DataBits = 8;
            sp.Handshake = Handshake.None;
            sp.RtsEnable = true;

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


    }
}