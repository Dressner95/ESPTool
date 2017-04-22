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
        String scans2Make = "5";
        int currentScan;
        public int[] vals2Average = new int[12];
        public int[] averages = new int [12];
        bool doneScanning = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void tryConnection(object sender, EventArgs e)
        {
            portToUse = new SerialPort(comPort.Text, 115200, Parity.None, 8, StopBits.One);
            portToUse.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            portToUse.Open();
            scanButton.Enabled = true;

            connectButton.BackColor = Color.LawnGreen;
            espStatus.BackColor = Color.LawnGreen;
            //portToUse.Close();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            processText(indata.Replace("\r", ""));
            Debug.Print(indata);            
        }
         void processText(String fromESP)
        {
            if (Int32.TryParse(fromESP, out currentScan))
            {
                scanProgress.Invoke(new MethodInvoker(delegate { scanProgress.Value = currentScan + 1; }));

                if ((currentScan + 1) == Int32.Parse(scans2Make))
                {
                    Debug.Print("doneScanning = true");
                    copyButton.Invoke(new MethodInvoker(delegate { copyButton.Enabled = true; }));
                    scanButton.Invoke(new MethodInvoker(delegate { scanButton.Enabled = true; }));
                    doneScanning = true;
                }
                else
                {
                    Debug.Print("doneScanning = false");
                    doneScanning = false;
                }
            }
            string[] data = fromESP.Split('-');
            Debug.Print("data in = " + data[0]);
            switch (data[0])
            {
                case "done":
                    if (doneScanning)
                    {
                        Debug.Print("calc averages");
                        // take average
                        for (int i = 0; i < 12; i++ )
                        {
                            Debug.Print(vals2Average[i].ToString());
                            if (vals2Average[i] != 0)
                            {
                                averages[i] = vals2Average[i] / Int32.Parse(scanNumber.Text);
                                Debug.Print(i + vals2Average[i].ToString());
                                Debug.Print(i + averages[i].ToString());
                                vals2Average[i] = 0;
                            }
                            else
                            {
                                averages[i] = 0;
                                Debug.Print("Average is 0");
                            }
                            
                        }
                        // print all to tables
                        esp01Text.Invoke(new MethodInvoker(delegate { esp01Text.Text = "-" + averages[0].ToString(); }));
                        esp02Text.Invoke(new MethodInvoker(delegate { esp02Text.Text = "-" + averages[1].ToString(); }));
                        esp03Text.Invoke(new MethodInvoker(delegate { esp03Text.Text = "-" + averages[2].ToString(); }));
                        esp04Text.Invoke(new MethodInvoker(delegate { esp04Text.Text = "-" + averages[3].ToString(); }));
                        esp05Text.Invoke(new MethodInvoker(delegate { esp05Text.Text = "-" + averages[4].ToString(); }));
                        esp06Text.Invoke(new MethodInvoker(delegate { esp06Text.Text = "-" + averages[5].ToString(); }));
                        esp07Text.Invoke(new MethodInvoker(delegate { esp07Text.Text = "-" + averages[6].ToString(); }));
                        esp08Text.Invoke(new MethodInvoker(delegate { esp08Text.Text = "-" + averages[7].ToString(); }));
                        esp09Text.Invoke(new MethodInvoker(delegate { esp09Text.Text = "-" + averages[8].ToString(); }));
                        esp10Text.Invoke(new MethodInvoker(delegate { esp10Text.Text = "-" + averages[9].ToString(); }));
                        esp11Text.Invoke(new MethodInvoker(delegate { esp11Text.Text = "-" + averages[10].ToString(); }));
                        esp12Text.Invoke(new MethodInvoker(delegate { esp12Text.Text = "-" + averages[11].ToString(); }));
                    }
                    espStatus.BackColor = Color.LawnGreen;
                    break;
                case "busy":
                    espStatus.BackColor = Color.Yellow;
                    break;
                case "howmany":
                    Debug.Print("sending scan amount");
                    portToUse.Write(scans2Make);             
                    break;
                case "ESP01":
                    if (esp01Text.InvokeRequired)
                    {
                        vals2Average[0] += Int32.Parse(data[1]);
                        //esp01Text.Invoke(new MethodInvoker(delegate { esp01Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP02":
                    if (esp02Text.InvokeRequired)
                    {
                        vals2Average[1] += Int32.Parse(data[1]);
                        //esp02Text.Invoke(new MethodInvoker(delegate { esp02Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP03":
                    if (esp03Text.InvokeRequired)
                    {
                        vals2Average[2] += Int32.Parse(data[1]);                       
                        //esp03Text.Invoke(new MethodInvoker(delegate { esp03Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP04":
                    if (esp04Text.InvokeRequired)
                    {
                        vals2Average[3] += Int32.Parse(data[1]);
                        //esp04Text.Invoke(new MethodInvoker(delegate { esp04Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP05":
                    if (esp05Text.InvokeRequired)
                    {
                        vals2Average[4] += Int32.Parse(data[1]);
                        //esp05Text.Invoke(new MethodInvoker(delegate { esp05Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP06":
                    if (esp06Text.InvokeRequired)
                    {
                        vals2Average[5] += Int32.Parse(data[1]);
                        //esp06Text.Invoke(new MethodInvoker(delegate { esp06Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP07":
                    if (esp07Text.InvokeRequired)
                    {
                        vals2Average[6] += Int32.Parse(data[1]);
                        //esp07Text.Invoke(new MethodInvoker(delegate { esp07Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP08":
                    if (esp08Text.InvokeRequired)
                    {
                        vals2Average[7] += Int32.Parse(data[1]);
                        Debug.Print("Current value to average = " + vals2Average[7].ToString());
                        //esp08Text.Invoke(new MethodInvoker(delegate { esp08Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP09":
                    if (esp09Text.InvokeRequired)
                    {
                        vals2Average[8] += Int32.Parse(data[1]);
                        //esp09Text.Invoke(new MethodInvoker(delegate { esp09Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP10":
                    if (esp10Text.InvokeRequired)
                    {
                        vals2Average[9] += Int32.Parse(data[1]);
                        //esp10Text.Invoke(new MethodInvoker(delegate { esp10Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP11":
                    if (esp11Text.InvokeRequired)
                    {
                        vals2Average[10] += Int32.Parse(data[1]);
                        //esp11Text.Invoke(new MethodInvoker(delegate { esp11Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP12":
                    if (esp12Text.InvokeRequired)
                    {
                        vals2Average[11] += Int32.Parse(data[1]);
                        //esp12Text.Invoke(new MethodInvoker(delegate { esp12Text.Text = "-" + data[1]; }));
                    }
                    break;

            }
        }
        private void scanButton_Click(object sender, EventArgs e)
        {
            portToUse.Write("scan"); //start scan protocol ESP side
            Debug.Print("sent scan command");
            doneScanning = false; //reset conditional variables
            scanProgress.Invoke(new MethodInvoker(delegate { scanProgress.Value = 0; }));
            scanProgress.Invoke(new MethodInvoker(delegate { scanProgress.Maximum = Int32.Parse(scans2Make); }));
            esp01Text.Invoke(new MethodInvoker(delegate { esp01Text.Text = ""; })); //Clear all past values
            esp02Text.Invoke(new MethodInvoker(delegate { esp02Text.Text = ""; }));
            esp03Text.Invoke(new MethodInvoker(delegate { esp03Text.Text = ""; }));
            esp04Text.Invoke(new MethodInvoker(delegate { esp04Text.Text = ""; }));
            esp05Text.Invoke(new MethodInvoker(delegate { esp05Text.Text = ""; }));
            esp06Text.Invoke(new MethodInvoker(delegate { esp06Text.Text = ""; }));
            esp07Text.Invoke(new MethodInvoker(delegate { esp07Text.Text = ""; }));
            esp08Text.Invoke(new MethodInvoker(delegate { esp08Text.Text = ""; }));
            esp09Text.Invoke(new MethodInvoker(delegate { esp09Text.Text = ""; }));
            esp10Text.Invoke(new MethodInvoker(delegate { esp10Text.Text = ""; }));
            esp11Text.Invoke(new MethodInvoker(delegate { esp11Text.Text = ""; }));
            esp12Text.Invoke(new MethodInvoker(delegate { esp12Text.Text = ""; }));
            copyButton.Invoke(new MethodInvoker(delegate { copyButton.Enabled = false; }));
            scanButton.Invoke(new MethodInvoker(delegate { scanButton.Enabled = false; }));

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(esp01Text.Text + "\t" + esp02Text.Text + "\t" + esp03Text.Text + "\t" + esp04Text.Text + "\t" + esp05Text.Text + "\t" + esp06Text.Text + "\t" + esp06Text.Text + "\t" + esp07Text.Text + "\t" + esp08Text.Text + "\t" + esp09Text.Text + "\t" + esp10Text.Text + "\t" + esp11Text.Text + "\t" + esp12Text.Text);
        }

        private void scanNumber_TextChanged(object sender, EventArgs e)
        {
            scans2Make = scanNumber.Text;
            Debug.Print(scans2Make);
        }
    }
}
