using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TermometrArduino
{
    public partial class Form1 : Form
    {

        private String[] ports;
        private DialogResult result;
        private SerialPort serialPort;
        public Form1()
        {
            
            InitializeComponent();
           // boundRate.SelectedIndex = 5;
            try
            {
                ports = SerialPort.GetPortNames();
            }
            catch (Win32Exception e) {
                MessageBox.Show(e.Message);
            }

            if (ports.Length == 0) {
                result =  MessageBox.Show("Nie wykryto portów. Aplikacja zostanie zamknięta");
            }

            if (result == DialogResult.OK) {
               //   Environment.Exit(1);
            }

            foreach (String port in ports) {
                comPorList.Items.Add(new { Text = port, Value = port });
            }

        }

        private void comPorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            boundRate.Visible = true;
        }


        private void boundRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) {
                serialPort.Close();
            }

            if (comPorList.SelectedIndex >= 0) {
                serialPort = new SerialPort(comPorList.SelectedValue.ToString());

                serialPort.BaudRate =  Int32.Parse(boundRate.SelectedValue.ToString());
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = true;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(dataHandler);

                try
                {
                    serialPort.Open();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataHandler(object sender, SerialDataReceivedEventArgs e) {
            SerialPort serial = (SerialPort)sender;
            string data = serial.ReadExisting();
            processRecivedData(data);
        }

        private void processRecivedData(String data) {
            String[] split = data.Split(new [] {";"}, StringSplitOptions.RemoveEmptyEntries);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) {
                serialPort.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) {
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen) { 
                
            }
        }

    }
}
