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
            portToUse = new SerialPort(comPort.Text, 115200, Parity.None, 8, StopBits.One);
            portToUse.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            portToUse.Open();

            connectButton.BackColor = Color.LawnGreen;
            //portToUse.Close();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            setText(indata);
            //Debug.Print("Data Received:");
            Debug.Print(indata);            
        }
         void setText(String fromArd)
        {
            string[] data = fromArd.Split('-');
            switch (data[0])
            {
                case "ESP01":
                    if (esp01Text.InvokeRequired)
                    {
                        esp01Text.Invoke(new MethodInvoker(delegate { esp01Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP02":
                    if (esp02Text.InvokeRequired)
                    {
                        esp02Text.Invoke(new MethodInvoker(delegate { esp02Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP03":
                    if (esp03Text.InvokeRequired)
                    {
                        esp03Text.Invoke(new MethodInvoker(delegate { esp03Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP04":
                    if (esp04Text.InvokeRequired)
                    {
                        esp04Text.Invoke(new MethodInvoker(delegate { esp04Text.Text = "-" + data[1]; }));
                    }
                    break;


            }
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
            portToUse.Write("scan");            
        }

        private void copyButton_Click(object sender, EventArgs e)
        {

        }

        private void ESP01_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
