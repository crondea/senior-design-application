using senior_design_application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senior_design_application
{
    public partial class Form1 : Form
    {
        string[] ports;
        string desiredPort;
        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                listBoxPorts.Items.Add(port);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    // Tell the robot to go forward
                    Background.SendMessage(desiredPort, "1");    // go
                    break;
                case Keys.Down:
                    // Tell the robot to go backward
                    //Probably want to stop then go backward
                    Background.SendMessage(desiredPort, "0");    // stop
                    Background.SendMessage(desiredPort, "2");    // back
                    break;
                case Keys.Right:
                    // Tell the robot to turn right
                    // Probably want to stop then turn right
                    Background.SendMessage(desiredPort, "0");    // stop
                    Background.SendMessage(desiredPort, "3");    // right
                    break;
                case Keys.Left:
                    // Tell the robot to turn left
                    // Probably want to stop then turn left
                    Background.SendMessage(desiredPort, "0");    // stop
                    Background.SendMessage(desiredPort, "4");    // left
                    break;
                case Keys.Space:
                    Background.SendMessage(desiredPort, "0");    // stop
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// The purpose of this function is to initialize the system connection to the bluetooth module.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
    
            try
            {
                desiredPort = listBoxPorts.SelectedItem.ToString();
            }
            catch{}
        }

        private void buttonKickstand_Click(object sender, EventArgs e)
        {

        }

        private void buttonEStop_Click(object sender, EventArgs e)
        {
            Background.SendMessage(desiredPort, "0");
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            MessageBox.Show(desiredPort);

            Background.SendMessage(desiredPort, "1");
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            Background.SendMessage(desiredPort, "0");
            Background.SendMessage(desiredPort, "2");
        }

        private void buttonRightTurn_Click(object sender, EventArgs e)
        {
            Background.SendMessage(desiredPort, "0");
            Background.SendMessage(desiredPort, "3");
        }

        private void buttonLeftTurn_Click(object sender, EventArgs e)
        {
            Background.SendMessage(desiredPort, "0");
            Background.SendMessage(desiredPort, "4");

        }


    }
}
