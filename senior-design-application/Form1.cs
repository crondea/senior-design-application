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
        public Form1()
        {
            InitializeComponent();

            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    // Tell the robot to go forward
                    Background.SendMessage("1");
                    break;
                case Keys.Down:
                    // Tell the robot to go backward
                    Background.SendMessage("0");
                    //Probably want to stop then go backward
                    break;
                case Keys.Right:
                    // Tell the robot to turn right
                    // Probably want to stop then turn right
                    break;
                case Keys.Left:
                    // Tell the robot to turn left
                    // Probably want to stop then turn left
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// The purpose of this function is to initialize the system connection to the bluetooth module.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartup_Click(object sender, EventArgs e)
        {
            //if (Background.connectAsClient() == false)
            //{
            //    // Connection failed
            //}
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonKickstand_Click(object sender, EventArgs e)
        {

        }

        private void buttonEStop_Click(object sender, EventArgs e)
        {
            Background.SendMessage("estop");
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            //Background.GetInfo();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            Background.SendMessage("1");
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            Background.SendMessage("0");
        }

        private void buttonRightTurn_Click(object sender, EventArgs e)
        {
            Background.SendMessage("leftturn");
        }

        private void buttonLeftTurn_Click(object sender, EventArgs e)
        {
            Background.SendMessage("rightturn");
        }


    }
}
