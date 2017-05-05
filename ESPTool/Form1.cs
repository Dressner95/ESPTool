﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Linq;


namespace ESPTool
{
    public partial class Form1 : Form
    {
        private SerialPort portToUse;
        String scans2Make = "5";
        int currentScan;
        int[] reset = new int[] { 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500 };
        public int[] vals2Average = new int[12];
        public int[] averages = new int [12];
        bool doneScanning = false;
        Dictionary<string, int> ESPValues = new Dictionary<string, int>();

        List<Tuple<string,string,int>> espList = new List<Tuple<string,string,int>>();
        List<Tuple<string, string, int>> sortedList = new List<Tuple<string, string, int>>();
        Excel.Application xlApp;
        Excel.Workbook xlBook;
        Excel._Worksheet xlSheet;
        Excel.Range UsedRange;
        int rowCount;
        int columnNumber;
        int searchBound = 10; //sensativity to initial pulling from excel sheet

        List<Tuple<string, float, int>> possibleLocations = new List<Tuple<string, float, int>>();
        Dictionary<string, float> scoredLocations  = new Dictionary<string, float>();
        //Scored list
        List<Tuple<string, float>> scoredList = new List<Tuple<string, float>>();
        List<Tuple<string, float>> finalList = new List<Tuple<string, float>>();


        public Form1()
        {
            InitializeComponent();
            xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Open(@"C:\Users\David\Documents\Sensor Collect - 422.xlsx");
            //xlBook = xlApp.Workbooks.Open(@"C:\Users\Mark IV\Documents\GitHub\ESPTool\ESPTool\Sensor Collect - 422.xlsx");
            xlSheet = xlBook.Worksheets["All"];
            UsedRange = xlSheet.UsedRange;
            rowCount = UsedRange.Row + UsedRange.Rows.Count - 1;
        }

        private void tryConnection(object sender, EventArgs e)
        {
            portToUse = new SerialPort(comPort.Text, 9600, Parity.None, 8, StopBits.One);
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
                                averages[i] = vals2Average[i] / Int32.Parse(scanNumber.Text);
                                Debug.Print(i + vals2Average[i].ToString());
                                Debug.Print(i + averages[i].ToString());
                                vals2Average[i] = 500;
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
                        for (int i = 0; i < 10; i++) //Assign espname and average to dictionary
                        {
                            string numberToUse;
                            if (i == 9)
                            {
                                numberToUse = "10";
                            }
                            else
                            {
                                numberToUse = "0" + (i + 1).ToString();
                            }
                            string ESPname = "ESP" + numberToUse;
                            ESPValues.Add(ESPname,averages[i]);
                        }
                        //Classify into tuple list
                        foreach (KeyValuePair<string, int> entry in ESPValues)
                        {
                            // do something with entry.Value or entry.Key
                            string classToAssign = null;
                            if (entry.Value < 40)
                            {
                                classToAssign = "class40";
                            } else if (40 <= entry.Value && entry.Value < 50){
                                classToAssign = "class4050";
                            }else if (50 <= entry.Value && entry.Value < 60){
                                classToAssign = "class5060";
                            }else if (60 <= entry.Value && entry.Value < 70){
                                classToAssign = "class6070";
                            }else if (70 <= entry.Value && entry.Value < 80){
                                classToAssign = "class7080";
                            }else if (80 <= entry.Value && entry.Value < 90){
                                classToAssign = "class8090";
                            } else if (90 < entry.Value){
                                classToAssign = "class90";
                            }
                            else
                            {
                                classToAssign = "class100";
                            }

                            espList.Add(Tuple.Create(entry.Key,classToAssign,entry.Value));
                        }
                        /*
                        foreach (Tuple<string,string,int> tuple in espList){
                            Debug.Print(tuple.Item1 + "," + tuple.Item2 + "," + tuple.Item3.ToString());
                        }
                        */

                        //sort tuple List
                        sortedList = espList.OrderBy(x => x.Item3).ToList();
                        //topESP.Invoke(new MethodInvoker(delegate { topESP.Text = sortedList[0].Item1 + "," + sortedList[0].Item2 + "," + sortedList[0].Item3; }));
                        columnNumber = NameToColNumber(sortedList[0].Item1);
                        foreach(Excel.Range row in xlSheet.UsedRange.Rows)
                        {
                            
                            if (Int32.Parse(xlSheet.UsedRange.Cells[row.Row, columnNumber].Value.ToString() as string) < sortedList[0].Item3 + searchBound && Int32.Parse(xlSheet.UsedRange.Cells[row.Row, columnNumber].Value.ToString() as string) > sortedList[0].Item3 - searchBound)
                            {
                                //add to list
                                possibleLocations.Add(Tuple.Create(xlSheet.Cells[row.Row, 1].Value.ToString() as string,0.0f, row.Row));
                            }
                            
                        }
                        /*
                        foreach (Tuple<string, int, int> tuple in possibleLocations)
                        {
                            Debug.Print(tuple.Item1 + "," + tuple.Item2.ToString() + "," + tuple.Item3.ToString());
                        }
                        */

                    foreach (Tuple<string,float,int> location in possibleLocations)
                        {
                            if (!scoredLocations.ContainsKey(location.Item1)){
                                scoredLocations.Add(location.Item1, 0.0f);
                            }
                            foreach (Tuple<string, string, int> esp in sortedList)
                            {
                                var weight = classToWeight(esp.Item2);
                                var diff = Math.Abs(esp.Item3 - Int32.Parse(xlSheet.UsedRange.Cells[location.Item3,NameToColNumber(esp.Item1)].Value.ToString() as string));
                                var rawScore = 100 - diff;
                                var score = rawScore * weight;
                                scoredLocations[location.Item1] += score;                                
                            }
                        }
                        //At this point the scored dict needs to be ordered and pushed
                        foreach (KeyValuePair<string, float> entry in scoredLocations)
                        {
                            scoredList.Add(Tuple.Create(entry.Key,entry.Value));
                        }
                        finalList = scoredList.OrderByDescending(x => x.Item2).ToList();
                        score0.Invoke(new MethodInvoker(delegate { score0.Text = finalList[0].Item1 + " Score= " + finalList[0].Item2.ToString(); }));
                        score1.Invoke(new MethodInvoker(delegate { score1.Text = finalList[1].Item1 + " Score= " + finalList[1].Item2.ToString(); }));
                        score2.Invoke(new MethodInvoker(delegate { score2.Text = finalList[2].Item1 + " Score= " + finalList[2].Item2.ToString(); }));
                        score3.Invoke(new MethodInvoker(delegate { score3.Text = finalList[3].Item1 + " Score= " + finalList[3].Item2.ToString(); }));
                        score4.Invoke(new MethodInvoker(delegate { score4.Text = finalList[4].Item1 + " Score= " + finalList[4].Item2.ToString(); }));
                        score5.Invoke(new MethodInvoker(delegate { score5.Text = finalList[5].Item1 + " Score= " + finalList[5].Item2.ToString(); }));
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
                        vals2Average[0] += -100 + Int32.Parse(data[1]);
                        //esp01Text.Invoke(new MethodInvoker(delegate { esp01Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP02":
                    if (esp02Text.InvokeRequired)
                    {
                        vals2Average[1] += -100 + Int32.Parse(data[1]);
                        //esp02Text.Invoke(new MethodInvoker(delegate { esp02Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP03":
                    if (esp03Text.InvokeRequired)
                    {
                        vals2Average[2] += -100 + Int32.Parse(data[1]);                       
                        //esp03Text.Invoke(new MethodInvoker(delegate { esp03Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP04":
                    if (esp04Text.InvokeRequired)
                    {
                        vals2Average[3] += -100 + Int32.Parse(data[1]);
                        //esp04Text.Invoke(new MethodInvoker(delegate { esp04Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP05":
                    if (esp05Text.InvokeRequired)
                    {
                        vals2Average[4] += -100 + Int32.Parse(data[1]);
                        //esp05Text.Invoke(new MethodInvoker(delegate { esp05Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP06":
                    if (esp06Text.InvokeRequired)
                    {
                        vals2Average[5] += -100 + Int32.Parse(data[1]);
                        //esp06Text.Invoke(new MethodInvoker(delegate { esp06Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP07":
                    if (esp07Text.InvokeRequired)
                    {
                        vals2Average[6] += -100 + Int32.Parse(data[1]);
                        //esp07Text.Invoke(new MethodInvoker(delegate { esp07Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP08":
                    if (esp08Text.InvokeRequired)
                    {
                        vals2Average[7] += -100 + Int32.Parse(data[1]);
                        Debug.Print("Current value to average = " + vals2Average[7].ToString());
                        //esp08Text.Invoke(new MethodInvoker(delegate { esp08Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP09":
                    if (esp09Text.InvokeRequired)
                    {
                        vals2Average[8] += -100 + Int32.Parse(data[1]);
                        //esp09Text.Invoke(new MethodInvoker(delegate { esp09Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP10":
                    if (esp10Text.InvokeRequired)
                    {
                        vals2Average[9] += -100 + Int32.Parse(data[1]);
                        //esp10Text.Invoke(new MethodInvoker(delegate { esp10Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP11":
                    if (esp11Text.InvokeRequired)
                    {
                        vals2Average[10] += -100 + Int32.Parse(data[1]);
                        //esp11Text.Invoke(new MethodInvoker(delegate { esp11Text.Text = "-" + data[1]; }));
                    }
                    break;
                case "ESP12":
                    if (esp12Text.InvokeRequired)
                    {
                        vals2Average[11] += -100 + Int32.Parse(data[1]);
                        //esp12Text.Invoke(new MethodInvoker(delegate { esp12Text.Text = "-" + data[1]; }));
                    }
                    break;

            }
        }
        private void scanButton_Click(object sender, EventArgs e)
        {
            vals2Average = reset;
            averages = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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
            score0.Invoke(new MethodInvoker(delegate { score0.Text = ""; }));
            score1.Invoke(new MethodInvoker(delegate { score1.Text = ""; }));
            score2.Invoke(new MethodInvoker(delegate { score2.Text = ""; }));
            score3.Invoke(new MethodInvoker(delegate { score3.Text = ""; }));
            score4.Invoke(new MethodInvoker(delegate { score4.Text = ""; }));
            score5.Invoke(new MethodInvoker(delegate { score5.Text = ""; }));


            ESPValues.Clear();
            espList.Clear();
            sortedList.Clear();

            possibleLocations.Clear();
            scoredList.Clear();
            scoredLocations.Clear();

           // sortedValues.Clear();

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(esp01Text.Text + "\t" + esp02Text.Text + "\t" + esp03Text.Text + "\t" + esp04Text.Text + "\t" + esp05Text.Text + "\t" + esp06Text.Text + "\t" + esp07Text.Text + "\t" + esp08Text.Text + "\t" + esp09Text.Text + "\t" + esp10Text.Text + "\t" + esp11Text.Text + "\t" + esp12Text.Text);
        }

        private void scanNumber_TextChanged(object sender, EventArgs e)
        {
            scans2Make = scanNumber.Text;
            Debug.Print(scans2Make);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int NameToColNumber(string esp)
        {
            switch (esp)
            {
                case "ESP01":
                    return 2;
                case "ESP02":
                    return 3;
                case "ESP03":
                    return 4;
                case "ESP04":
                    return 5;
                case "ESP05":
                    return 6;
                case "ESP06":
                    return 7;
                case "ESP07":
                    return 8;
                case "ESP08":
                    return 9;
                case "ESP09":
                    return 10;
                case "ESP10":
                    return 11;
            }
            return 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            xlBook.Close();
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }
        private float classToWeight(string rssiClass)
        {
            switch (rssiClass)
            {
                case "class40":
                    return float.Parse(class40.Text);
                case "class4050":
                    return float.Parse(class4050.Text);
                case "class5060":
                    return float.Parse(class5060.Text);
                case "class6070":
                    return float.Parse(class6070.Text);
                case "class7080":
                    return float.Parse(class7080.Text);
                case "class8090":
                    return float.Parse(class8090.Text);
                case "class90":
                    return float.Parse(class90.Text);
                case "class100":
                    return 0;
            }
            return 0;
        }
    }
}
