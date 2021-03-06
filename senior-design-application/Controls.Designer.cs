﻿namespace senior_design_application
{
    partial class Controls
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
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.listBoxPorts = new System.Windows.Forms.ListBox();
            this.buttonEStop = new System.Windows.Forms.Button();
            this.buttonKickstand = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSpeedUp = new System.Windows.Forms.Button();
            this.buttonRightTurn = new System.Windows.Forms.Button();
            this.buttonLeftTurn = new System.Windows.Forms.Button();
            this.buttonSlowDown = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPB
            // 
            this.logoPB.ImageLocation = "C:\\Users\\Corey Rondeau\\Source\\Repos\\senior-design-application\\senior-design-appli" +
    "cation\\Images\\50073.jpg";
            this.logoPB.Location = new System.Drawing.Point(40, 18);
            this.logoPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(689, 407);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.listBoxPorts);
            this.groupBoxControls.Controls.Add(this.buttonEStop);
            this.groupBoxControls.Controls.Add(this.buttonKickstand);
            this.groupBoxControls.Controls.Add(this.buttonConnect);
            this.groupBoxControls.Location = new System.Drawing.Point(24, 479);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxControls.Size = new System.Drawing.Size(240, 465);
            this.groupBoxControls.TabIndex = 1;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // listBoxPorts
            // 
            this.listBoxPorts.FormattingEnabled = true;
            this.listBoxPorts.ItemHeight = 20;
            this.listBoxPorts.Location = new System.Drawing.Point(13, 29);
            this.listBoxPorts.Name = "listBoxPorts";
            this.listBoxPorts.Size = new System.Drawing.Size(211, 204);
            this.listBoxPorts.TabIndex = 8;
            // 
            // buttonEStop
            // 
            this.buttonEStop.BackColor = System.Drawing.Color.Red;
            this.buttonEStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEStop.Location = new System.Drawing.Point(12, 380);
            this.buttonEStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEStop.Name = "buttonEStop";
            this.buttonEStop.Size = new System.Drawing.Size(213, 74);
            this.buttonEStop.TabIndex = 7;
            this.buttonEStop.Text = "Emergency Stop";
            this.buttonEStop.UseVisualStyleBackColor = false;
            this.buttonEStop.Click += new System.EventHandler(this.buttonEStop_Click);
            // 
            // buttonKickstand
            // 
            this.buttonKickstand.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonKickstand.Enabled = false;
            this.buttonKickstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKickstand.Location = new System.Drawing.Point(11, 321);
            this.buttonKickstand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKickstand.Name = "buttonKickstand";
            this.buttonKickstand.Size = new System.Drawing.Size(214, 50);
            this.buttonKickstand.TabIndex = 2;
            this.buttonKickstand.Text = "Lower Kickstand";
            this.buttonKickstand.UseVisualStyleBackColor = false;
            this.buttonKickstand.Click += new System.EventHandler(this.buttonKickstand_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(13, 244);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(211, 68);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSpeedUp
            // 
            this.buttonSpeedUp.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSpeedUp.Location = new System.Drawing.Point(452, 541);
            this.buttonSpeedUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSpeedUp.Name = "buttonSpeedUp";
            this.buttonSpeedUp.Size = new System.Drawing.Size(120, 86);
            this.buttonSpeedUp.TabIndex = 3;
            this.buttonSpeedUp.Text = "Speed Up";
            this.buttonSpeedUp.UseVisualStyleBackColor = false;
            this.buttonSpeedUp.Click += new System.EventHandler(this.buttonSpeedUp_Click);
            // 
            // buttonRightTurn
            // 
            this.buttonRightTurn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRightTurn.Location = new System.Drawing.Point(607, 640);
            this.buttonRightTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRightTurn.Name = "buttonRightTurn";
            this.buttonRightTurn.Size = new System.Drawing.Size(120, 86);
            this.buttonRightTurn.TabIndex = 4;
            this.buttonRightTurn.Text = "Right Turn";
            this.buttonRightTurn.UseVisualStyleBackColor = false;
            this.buttonRightTurn.Click += new System.EventHandler(this.buttonRightTurn_Click);
            // 
            // buttonLeftTurn
            // 
            this.buttonLeftTurn.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonLeftTurn.Location = new System.Drawing.Point(299, 640);
            this.buttonLeftTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeftTurn.Name = "buttonLeftTurn";
            this.buttonLeftTurn.Size = new System.Drawing.Size(120, 86);
            this.buttonLeftTurn.TabIndex = 5;
            this.buttonLeftTurn.Text = "Left Turn";
            this.buttonLeftTurn.UseVisualStyleBackColor = false;
            this.buttonLeftTurn.Click += new System.EventHandler(this.buttonLeftTurn_Click);
            // 
            // buttonSlowDown
            // 
            this.buttonSlowDown.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSlowDown.Location = new System.Drawing.Point(452, 738);
            this.buttonSlowDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSlowDown.Name = "buttonSlowDown";
            this.buttonSlowDown.Size = new System.Drawing.Size(120, 86);
            this.buttonSlowDown.TabIndex = 6;
            this.buttonSlowDown.Text = "Slow Down";
            this.buttonSlowDown.UseVisualStyleBackColor = false;
            this.buttonSlowDown.Click += new System.EventHandler(this.buttonSlowDown_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.Location = new System.Drawing.Point(19, 449);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(295, 22);
            this.labelConnect.TabIndex = 7;
            this.labelConnect.Text = "Select a port and click Connect:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Count:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(511, 451);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 20);
            this.labelCount.TabIndex = 9;
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(760, 958);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonSlowDown);
            this.Controls.Add(this.buttonLeftTurn);
            this.Controls.Add(this.buttonRightTurn);
            this.Controls.Add(this.buttonSpeedUp);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.logoPB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Controls";
            this.Text = "Robot Controller";
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonKickstand;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSpeedUp;
        private System.Windows.Forms.Button buttonRightTurn;
        private System.Windows.Forms.Button buttonLeftTurn;
        private System.Windows.Forms.Button buttonSlowDown;
        private System.Windows.Forms.Button buttonEStop;
        private System.Windows.Forms.ListBox listBoxPorts;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
    }
}

