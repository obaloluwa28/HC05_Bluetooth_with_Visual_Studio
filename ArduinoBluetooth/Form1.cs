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

namespace ArduinoBluetooth
{
    public partial class ArduinoBluetoothForm : Form
    {
        int count;
        public ArduinoBluetoothForm()
        {
            InitializeComponent();
            StatusLabel.ForeColor = System.Drawing.Color.Red;
            StatusLabel.Text = "Arduino Disconnected!";
            DisconnectBut.Enabled = false;

            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
        }

        private void DataReceived (object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spl = (SerialPort)sender;
                InBoxTBox.Text = ("Data" + count + " " + spl.ReadLine() + "\n");
                count++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //  Disconnect Button
        private void DisconnectBut_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                serialPort1.Close();
                ConnectButton.Enabled = true;
                StatusLabel.Text = "Arduino Disconnected!";
                StatusLabel.ForeColor = System.Drawing.Color.Red;
                DisconnectBut.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  Connect Button
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                serialPort1.PortName = PortComboBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);
                serialPort1.Open();
                DisconnectBut.Enabled = true;
                ConnectButton.Enabled = false;
                StatusLabel.Text = "Arduino Connected";
                StatusLabel.ForeColor = System.Drawing.Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string sendtxt = SendTextBox.Text;
            serialPort1.Write(sendtxt);
        }
    }
}
