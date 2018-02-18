namespace senior_design_application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEStop = new System.Windows.Forms.Button();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonKickstand = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonStartup = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonRightTurn = new System.Windows.Forms.Button();
            this.buttonLeftTurn = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPB
            // 
            this.logoPB.ImageLocation = "C:\\Users\\corey_000\\Documents\\Visual Studio 2017\\SDImage.JPG";
            this.logoPB.Location = new System.Drawing.Point(27, 12);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(784, 132);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEStop);
            this.groupBox1.Controls.Add(this.buttonUpdateTable);
            this.groupBox1.Controls.Add(this.buttonKickstand);
            this.groupBox1.Controls.Add(this.buttonShutdown);
            this.groupBox1.Controls.Add(this.buttonStartup);
            this.groupBox1.Location = new System.Drawing.Point(27, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonEStop
            // 
            this.buttonEStop.BackColor = System.Drawing.Color.Red;
            this.buttonEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEStop.Location = new System.Drawing.Point(7, 183);
            this.buttonEStop.Name = "buttonEStop";
            this.buttonEStop.Size = new System.Drawing.Size(114, 48);
            this.buttonEStop.TabIndex = 7;
            this.buttonEStop.Text = "Emergency Stop";
            this.buttonEStop.UseVisualStyleBackColor = false;
            this.buttonEStop.Click += new System.EventHandler(this.buttonEStop_Click);
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonUpdateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTable.Location = new System.Drawing.Point(6, 145);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(114, 32);
            this.buttonUpdateTable.TabIndex = 3;
            this.buttonUpdateTable.Text = "Update Table";
            this.buttonUpdateTable.UseVisualStyleBackColor = false;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonKickstand
            // 
            this.buttonKickstand.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonKickstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKickstand.Location = new System.Drawing.Point(6, 107);
            this.buttonKickstand.Name = "buttonKickstand";
            this.buttonKickstand.Size = new System.Drawing.Size(114, 32);
            this.buttonKickstand.TabIndex = 2;
            this.buttonKickstand.Text = "Lower Kickstand";
            this.buttonKickstand.UseVisualStyleBackColor = false;
            this.buttonKickstand.Click += new System.EventHandler(this.buttonKickstand_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShutdown.Location = new System.Drawing.Point(7, 69);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(114, 32);
            this.buttonShutdown.TabIndex = 1;
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = false;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonStartup
            // 
            this.buttonStartup.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartup.Location = new System.Drawing.Point(7, 19);
            this.buttonStartup.Name = "buttonStartup";
            this.buttonStartup.Size = new System.Drawing.Size(114, 44);
            this.buttonStartup.TabIndex = 0;
            this.buttonStartup.Text = "Startup";
            this.buttonStartup.UseVisualStyleBackColor = false;
            this.buttonStartup.Click += new System.EventHandler(this.buttonStartup_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonForward.Location = new System.Drawing.Point(306, 170);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(80, 56);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonRightTurn
            // 
            this.buttonRightTurn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRightTurn.Location = new System.Drawing.Point(412, 235);
            this.buttonRightTurn.Name = "buttonRightTurn";
            this.buttonRightTurn.Size = new System.Drawing.Size(80, 56);
            this.buttonRightTurn.TabIndex = 4;
            this.buttonRightTurn.Text = "Right Turn";
            this.buttonRightTurn.UseVisualStyleBackColor = false;
            this.buttonRightTurn.Click += new System.EventHandler(this.buttonRightTurn_Click);
            // 
            // buttonLeftTurn
            // 
            this.buttonLeftTurn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonLeftTurn.Location = new System.Drawing.Point(204, 235);
            this.buttonLeftTurn.Name = "buttonLeftTurn";
            this.buttonLeftTurn.Size = new System.Drawing.Size(80, 56);
            this.buttonLeftTurn.TabIndex = 5;
            this.buttonLeftTurn.Text = "Left Turn";
            this.buttonLeftTurn.UseVisualStyleBackColor = false;
            this.buttonLeftTurn.Click += new System.EventHandler(this.buttonLeftTurn_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonBackward.Location = new System.Drawing.Point(306, 299);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(80, 56);
            this.buttonBackward.TabIndex = 6;
            this.buttonBackward.Text = "Backward";
            this.buttonBackward.UseVisualStyleBackColor = false;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(823, 399);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.buttonLeftTurn);
            this.Controls.Add(this.buttonRightTurn);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoPB);
            this.Name = "Form1";
            this.Text = "Robot Controller";
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKickstand;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonStartup;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fields;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonRightTurn;
        private System.Windows.Forms.Button buttonLeftTurn;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonEStop;
    }
}

