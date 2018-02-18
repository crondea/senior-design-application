using senior_design_application.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        /// <summary>
        /// The purpose of this function is to initialize the system connection to the bluetooth module.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartup_Click(object sender, EventArgs e)
        {
            if (Background.connectAsClient() == false)
            {
                // Connection failed
            }
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonKickstand_Click(object sender, EventArgs e)
        {

        }

        private void buttonEStop_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {

        }

        private void buttonForward_Click(object sender, EventArgs e)
        {

        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {

        }

        private void buttonRightTurn_Click(object sender, EventArgs e)
        {

        }

        private void buttonLeftTurn_Click(object sender, EventArgs e)
        {

        }
    }
}
