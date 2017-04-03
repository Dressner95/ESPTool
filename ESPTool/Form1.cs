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
            portToUse = new SerialPort();
            portToUse.BaudRate = 115200;
            portToUse.PortName = comPort.Text;
            portToUse.Open();

            connectButton.BackColor = Color.LawnGreen;
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
    }
}
