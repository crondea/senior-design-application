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
    public partial class Controls : Form
    {
        string[] ports;
        string desiredPort;
        public Controls()
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
            int value = 0;
            switch (keyData)
            {
                case Keys.Up:
                    // Tell the robot to go forward
                    value = Background.countHandler(1);
                    Background.sendIndex();
                    labelCount.Text = value.ToString();
                    break;
                case Keys.Down:
                    // Tell the robot to go backward
                    value = Background.countHandler(-1);
                    Background.sendIndex();
                    labelCount.Text = value.ToString();
                    break;
                case Keys.Right:
                    // Tell the robot to turn right
                    //Background.SendMessage("3");    // right
                    break;
                case Keys.Left:
                    // Tell the robot to turn left
                    //Background.SendMessage("4");    // left
                    break;
                case Keys.Space:
                    value = Background.countHandler(0);
                    Background.sendIndex();
                    labelCount.Text = value.ToString();
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
                Background.PortSetup(desiredPort);
            }
            catch{}   
        }

        private void buttonKickstand_Click(object sender, EventArgs e)
        {

        }

        private void buttonEStop_Click(object sender, EventArgs e)
        {
            int value = Background.countHandler(0);
            Background.sendIndex();
            labelCount.Text = value.ToString();
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            int value = Background.countHandler(1);
            Background.sendIndex();
            labelCount.Text = value.ToString();
        }

        private void buttonSlowDown_Click(object sender, EventArgs e)
        {
            int value = Background.countHandler(-1);
            Background.sendIndex();
            labelCount.Text = value.ToString();
        }

        private void buttonRightTurn_Click(object sender, EventArgs e)
        {
            //Background.SendMessage("3");
        }

        private void buttonLeftTurn_Click(object sender, EventArgs e)
        {
            //Background.SendMessage("4");
        }
    }
}
