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
        public Form1()
        {
            
            InitializeComponent();
            try
            {
                ports = SerialPort.GetPortNames();
            }
            catch (Win32Exception e) {
                MessageBox.Show(e.Message);
            }

            if (ports.Length == 0) {
                result =  MessageBox.Show("Nie wykryto portów");
            }

            if (result == DialogResult.OK) {
                MessageBox.Show("a");
                Environment.Exit(1);
            }

            foreach (String port in ports) {
                comPorList.Items.Add(new { Text = port, Value = port });
            }

        }
    }
}
