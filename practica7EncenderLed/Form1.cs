using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace practica7EncenderLed
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }

        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
        private void CerrandoForm1(object sender , FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
    }
}
