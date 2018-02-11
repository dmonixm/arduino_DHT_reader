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
            boundRate.SelectedIndex = 5;
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



    }
}
