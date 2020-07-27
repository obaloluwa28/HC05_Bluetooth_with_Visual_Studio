namespace ArduinoBluetooth
{
    partial class ArduinoBluetoothForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectBut = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.InBoxTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect Bluetooth";
            // 
            // PortComboBox
            // 
            this.PortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PortComboBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12"});
            this.PortComboBox.Location = new System.Drawing.Point(16, 76);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(121, 26);
            this.PortComboBox.TabIndex = 1;
            this.PortComboBox.Text = "COM Ports";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BaudRateComboBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "38400"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(143, 76);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 26);
            this.BaudRateComboBox.TabIndex = 2;
            this.BaudRateComboBox.Text = "Baud Rate";
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.Color.Blue;
            this.ConnectButton.Location = new System.Drawing.Point(293, 76);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(99, 26);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "&Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectBut
            // 
            this.DisconnectBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DisconnectBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisconnectBut.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBut.ForeColor = System.Drawing.Color.Blue;
            this.DisconnectBut.Location = new System.Drawing.Point(293, 117);
            this.DisconnectBut.Name = "DisconnectBut";
            this.DisconnectBut.Size = new System.Drawing.Size(99, 26);
            this.DisconnectBut.TabIndex = 4;
            this.DisconnectBut.Text = "Disconnect";
            this.DisconnectBut.UseVisualStyleBackColor = false;
            this.DisconnectBut.Click += new System.EventHandler(this.DisconnectBut_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendButton.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SendButton.Location = new System.Drawing.Point(195, 175);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(69, 25);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTextBox.Location = new System.Drawing.Point(16, 175);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(173, 25);
            this.SendTextBox.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(13, 125);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 17);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Send Value";
            // 
            // InBoxTBox
            // 
            this.InBoxTBox.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InBoxTBox.Location = new System.Drawing.Point(17, 206);
            this.InBoxTBox.Multiline = true;
            this.InBoxTBox.Name = "InBoxTBox";
            this.InBoxTBox.Size = new System.Drawing.Size(172, 117);
            this.InBoxTBox.TabIndex = 9;
            // 
            // ArduinoBluetoothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.InBoxTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.DisconnectBut);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.BaudRateComboBox);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ArduinoBluetoothForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Control Via Bluetooth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectBut;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox InBoxTBox;
    }
}

