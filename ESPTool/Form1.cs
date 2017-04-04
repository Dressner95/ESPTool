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
using System.Diagnostics;

namespace ESPTool
{
    public partial class Form1 : Form
    {
        private SerialPort portToUse;
        public Form1()
        {
            InitializeComponent();

        }

        private void tryConnection(object sender, EventArgs e)
        {
            portToUse = new SerialPort(comPort.Text, 9600, Parity.Even, 8, StopBits.One);
            portToUse.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            portToUse.Open();

            connectButton.BackColor = Color.LawnGreen;
            //portToUse.Close();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            Debug.Print("Data Received:");
            Debug.Print(indata);
            //Console.Write(indata);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            
        }

    }
}
