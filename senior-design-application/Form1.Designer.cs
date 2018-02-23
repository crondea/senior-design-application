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
            this.logoPB.Location = new System.Drawing.Point(54, 23);
            this.logoPB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(1568, 254);
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
            this.groupBox1.Location = new System.Drawing.Point(54, 288);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(254, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonEStop
            // 
            this.buttonEStop.BackColor = System.Drawing.Color.Red;
            this.buttonEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEStop.Location = new System.Drawing.Point(14, 352);
            this.buttonEStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEStop.Name = "buttonEStop";
            this.buttonEStop.Size = new System.Drawing.Size(228, 92);
            this.buttonEStop.TabIndex = 7;
            this.buttonEStop.Text = "Emergency Stop";
            this.buttonEStop.UseVisualStyleBackColor = false;
            this.buttonEStop.Click += new System.EventHandler(this.buttonEStop_Click);
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonUpdateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTable.Location = new System.Drawing.Point(12, 279);
            this.buttonUpdateTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(228, 62);
            this.buttonUpdateTable.TabIndex = 3;
            this.buttonUpdateTable.Text = "Update Table";
            this.buttonUpdateTable.UseVisualStyleBackColor = false;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonKickstand
            // 
            this.buttonKickstand.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonKickstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKickstand.Location = new System.Drawing.Point(12, 206);
            this.buttonKickstand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonKickstand.Name = "buttonKickstand";
            this.buttonKickstand.Size = new System.Drawing.Size(228, 62);
            this.buttonKickstand.TabIndex = 2;
            this.buttonKickstand.Text = "Lower Kickstand";
            this.buttonKickstand.UseVisualStyleBackColor = false;
            this.buttonKickstand.Click += new System.EventHandler(this.buttonKickstand_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShutdown.Location = new System.Drawing.Point(14, 133);
            this.buttonShutdown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(228, 62);
            this.buttonShutdown.TabIndex = 1;
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = false;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonStartup
            // 
            this.buttonStartup.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartup.Location = new System.Drawing.Point(14, 37);
            this.buttonStartup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStartup.Name = "buttonStartup";
            this.buttonStartup.Size = new System.Drawing.Size(228, 85);
            this.buttonStartup.TabIndex = 0;
            this.buttonStartup.Text = "Startup";
            this.buttonStartup.UseVisualStyleBackColor = false;
            this.buttonStartup.Click += new System.EventHandler(this.buttonStartup_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonForward.Location = new System.Drawing.Point(612, 327);
            this.buttonForward.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(160, 108);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonRightTurn
            // 
            this.buttonRightTurn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRightTurn.Location = new System.Drawing.Point(824, 452);
            this.buttonRightTurn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRightTurn.Name = "buttonRightTurn";
            this.buttonRightTurn.Size = new System.Drawing.Size(160, 108);
            this.buttonRightTurn.TabIndex = 4;
            this.buttonRightTurn.Text = "Right Turn";
            this.buttonRightTurn.UseVisualStyleBackColor = false;
            this.buttonRightTurn.Click += new System.EventHandler(this.buttonRightTurn_Click);
            // 
            // buttonLeftTurn
            // 
            this.buttonLeftTurn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonLeftTurn.Location = new System.Drawing.Point(408, 452);
            this.buttonLeftTurn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonLeftTurn.Name = "buttonLeftTurn";
            this.buttonLeftTurn.Size = new System.Drawing.Size(160, 108);
            this.buttonLeftTurn.TabIndex = 5;
            this.buttonLeftTurn.Text = "Left Turn";
            this.buttonLeftTurn.UseVisualStyleBackColor = false;
            this.buttonLeftTurn.Click += new System.EventHandler(this.buttonLeftTurn_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonBackward.Location = new System.Drawing.Point(612, 575);
            this.buttonBackward.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(160, 108);
            this.buttonBackward.TabIndex = 6;
            this.buttonBackward.Text = "Backward";
            this.buttonBackward.UseVisualStyleBackColor = false;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1694, 765);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.buttonLeftTurn);
            this.Controls.Add(this.buttonRightTurn);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoPB);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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

