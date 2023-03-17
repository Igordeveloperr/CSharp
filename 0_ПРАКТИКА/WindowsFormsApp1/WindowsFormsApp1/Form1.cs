using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private WMIManager manager = new WMIManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SerialPort serial = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            comboBox1.Text = ports[ports.Length - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("подключиться"))
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                comboBox1.Enabled = false;
                button1.Text = "отключиться";

            }
            else
            {
                serialPort1.Close();
                comboBox1.Enabled = true;
                button1.Text = "подключиться";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                string dataType = serialPort1.ReadLine().Substring(0, 1);
                if (dataType == "L")
                {
                    string loadPercentage = manager.SendRequest("select * from win32_processor", "LoadPercentage");
                    serialPort1.Write(loadPercentage);
                    dataType = "";
                }
                else if (dataType == "V")
                {
                    string processorVoltage = manager.SendRequest("select * from win32_processor", "CurrentVoltage");
                    serialPort1.Write(processorVoltage);
                    dataType = "";
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
        }
    }
}
