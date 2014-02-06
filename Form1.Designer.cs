namespace WindowsFormsApplication1
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
            this.comboBox_comport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeviceData = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_comport
            // 
            this.comboBox_comport.FormattingEnabled = true;
            this.comboBox_comport.Location = new System.Drawing.Point(76, 6);
            this.comboBox_comport.Name = "comboBox_comport";
            this.comboBox_comport.Size = new System.Drawing.Size(69, 21);
            this.comboBox_comport.TabIndex = 0;
            this.comboBox_comport.SelectedIndexChanged += new System.EventHandler(this.comboBox_comport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comm Port";
            // 
            // lblDeviceData
            // 
            this.lblDeviceData.AutoSize = true;
            this.lblDeviceData.Location = new System.Drawing.Point(151, 9);
            this.lblDeviceData.Name = "lblDeviceData";
            this.lblDeviceData.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceData.TabIndex = 5;
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(67, 38);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(322, 20);
            this.txtMode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 155);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDeviceData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.comboBox_comport);
            this.Name = "Form1";
            this.Text = "USB-ISS - LCD03 example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_comport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeviceData;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label4;
    }
}

