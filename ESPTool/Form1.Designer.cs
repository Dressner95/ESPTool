namespace ESPTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.comPort = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.esp01Label = new System.Windows.Forms.Label();
            this.esp01Text = new System.Windows.Forms.TextBox();
            this.esp04Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.esp07Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.esp02Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.esp05Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.esp08Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.esp10Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.esp11Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.esp12Text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.esp09Text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.esp06Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.esp03Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.scanProgress = new System.Windows.Forms.ProgressBar();
            this.scanPanel = new System.Windows.Forms.Panel();
            this.espStatus = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.scanNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ESPPanel = new System.Windows.Forms.Panel();
            this.class40 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.class4050 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.class5060 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.class6070 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.class7080 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.class8090 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.class90 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.color90 = new System.Windows.Forms.Button();
            this.color8090 = new System.Windows.Forms.Button();
            this.color7080 = new System.Windows.Forms.Button();
            this.color6070 = new System.Windows.Forms.Button();
            this.color5060 = new System.Windows.Forms.Button();
            this.color4050 = new System.Windows.Forms.Button();
            this.color40 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.scanPanel.SuspendLayout();
            this.ESPPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.portLabel);
            this.panel1.Controls.Add(this.comPort);
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 105);
            this.panel1.TabIndex = 0;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Yellow;
            this.connectButton.Location = new System.Drawing.Point(145, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(118, 81);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.tryConnection);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(13, 45);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(69, 17);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "COM Port";
            // 
            // comPort
            // 
            this.comPort.Location = new System.Drawing.Point(13, 68);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(100, 22);
            this.comPort.TabIndex = 1;
            this.comPort.Text = "COM10";
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panelTitle.Location = new System.Drawing.Point(12, 9);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(105, 20);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Text = "Serial Config";
            // 
            // scanButton
            // 
            this.scanButton.Enabled = false;
            this.scanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.scanButton.Location = new System.Drawing.Point(29, 272);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(236, 105);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Enabled = false;
            this.copyButton.Location = new System.Drawing.Point(58, 412);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(178, 47);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // esp01Label
            // 
            this.esp01Label.AutoSize = true;
            this.esp01Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.esp01Label.Location = new System.Drawing.Point(11, 14);
            this.esp01Label.Name = "esp01Label";
            this.esp01Label.Size = new System.Drawing.Size(65, 20);
            this.esp01Label.TabIndex = 3;
            this.esp01Label.Text = "ESP 01";
            // 
            // esp01Text
            // 
            this.esp01Text.Location = new System.Drawing.Point(15, 38);
            this.esp01Text.Name = "esp01Text";
            this.esp01Text.Size = new System.Drawing.Size(75, 22);
            this.esp01Text.TabIndex = 4;
            // 
            // esp04Text
            // 
            this.esp04Text.Location = new System.Drawing.Point(15, 96);
            this.esp04Text.Name = "esp04Text";
            this.esp04Text.Size = new System.Drawing.Size(75, 22);
            this.esp04Text.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ESP 04";
            // 
            // esp07Text
            // 
            this.esp07Text.Location = new System.Drawing.Point(15, 159);
            this.esp07Text.Name = "esp07Text";
            this.esp07Text.Size = new System.Drawing.Size(75, 22);
            this.esp07Text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(11, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ESP 07";
            // 
            // esp02Text
            // 
            this.esp02Text.Location = new System.Drawing.Point(129, 38);
            this.esp02Text.Name = "esp02Text";
            this.esp02Text.Size = new System.Drawing.Size(75, 22);
            this.esp02Text.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(125, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ESP 02";
            // 
            // esp05Text
            // 
            this.esp05Text.Location = new System.Drawing.Point(129, 96);
            this.esp05Text.Name = "esp05Text";
            this.esp05Text.Size = new System.Drawing.Size(75, 22);
            this.esp05Text.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(125, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ESP 05";
            // 
            // esp08Text
            // 
            this.esp08Text.Location = new System.Drawing.Point(129, 159);
            this.esp08Text.Name = "esp08Text";
            this.esp08Text.Size = new System.Drawing.Size(75, 22);
            this.esp08Text.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(125, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ESP 08";
            // 
            // esp10Text
            // 
            this.esp10Text.Location = new System.Drawing.Point(15, 223);
            this.esp10Text.Name = "esp10Text";
            this.esp10Text.Size = new System.Drawing.Size(75, 22);
            this.esp10Text.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(11, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ESP 10";
            // 
            // esp11Text
            // 
            this.esp11Text.Location = new System.Drawing.Point(129, 223);
            this.esp11Text.Name = "esp11Text";
            this.esp11Text.Size = new System.Drawing.Size(75, 22);
            this.esp11Text.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(125, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "ESP 11";
            // 
            // esp12Text
            // 
            this.esp12Text.Location = new System.Drawing.Point(242, 223);
            this.esp12Text.Name = "esp12Text";
            this.esp12Text.Size = new System.Drawing.Size(75, 22);
            this.esp12Text.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(238, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "ESP 12";
            // 
            // esp09Text
            // 
            this.esp09Text.Location = new System.Drawing.Point(242, 159);
            this.esp09Text.Name = "esp09Text";
            this.esp09Text.Size = new System.Drawing.Size(75, 22);
            this.esp09Text.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(238, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "ESP 09";
            // 
            // esp06Text
            // 
            this.esp06Text.Location = new System.Drawing.Point(242, 96);
            this.esp06Text.Name = "esp06Text";
            this.esp06Text.Size = new System.Drawing.Size(75, 22);
            this.esp06Text.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(238, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "ESP 06";
            // 
            // esp03Text
            // 
            this.esp03Text.Location = new System.Drawing.Point(242, 38);
            this.esp03Text.Name = "esp03Text";
            this.esp03Text.Size = new System.Drawing.Size(75, 22);
            this.esp03Text.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(238, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "ESP 03";
            // 
            // scanProgress
            // 
            this.scanProgress.Location = new System.Drawing.Point(29, 383);
            this.scanProgress.Maximum = 10;
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(236, 23);
            this.scanProgress.Step = 1;
            this.scanProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.scanProgress.TabIndex = 28;
            // 
            // scanPanel
            // 
            this.scanPanel.Controls.Add(this.espStatus);
            this.scanPanel.Controls.Add(this.label13);
            this.scanPanel.Controls.Add(this.scanNumber);
            this.scanPanel.Controls.Add(this.label12);
            this.scanPanel.Location = new System.Drawing.Point(12, 147);
            this.scanPanel.Name = "scanPanel";
            this.scanPanel.Size = new System.Drawing.Size(276, 108);
            this.scanPanel.TabIndex = 29;
            // 
            // espStatus
            // 
            this.espStatus.BackColor = System.Drawing.Color.Red;
            this.espStatus.Location = new System.Drawing.Point(145, 12);
            this.espStatus.Name = "espStatus";
            this.espStatus.Size = new System.Drawing.Size(128, 74);
            this.espStatus.TabIndex = 3;
            this.espStatus.Text = "espStatus";
            this.espStatus.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Scan Number";
            // 
            // scanNumber
            // 
            this.scanNumber.Location = new System.Drawing.Point(14, 64);
            this.scanNumber.Name = "scanNumber";
            this.scanNumber.Size = new System.Drawing.Size(100, 22);
            this.scanNumber.TabIndex = 1;
            this.scanNumber.Text = "5";
            this.scanNumber.TextChanged += new System.EventHandler(this.scanNumber_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(10, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Scan Settings";
            // 
            // ESPPanel
            // 
            this.ESPPanel.Controls.Add(this.esp01Label);
            this.ESPPanel.Controls.Add(this.esp01Text);
            this.ESPPanel.Controls.Add(this.label1);
            this.ESPPanel.Controls.Add(this.esp04Text);
            this.ESPPanel.Controls.Add(this.label2);
            this.ESPPanel.Controls.Add(this.esp07Text);
            this.ESPPanel.Controls.Add(this.label3);
            this.ESPPanel.Controls.Add(this.esp02Text);
            this.ESPPanel.Controls.Add(this.label4);
            this.ESPPanel.Controls.Add(this.esp05Text);
            this.ESPPanel.Controls.Add(this.label5);
            this.ESPPanel.Controls.Add(this.esp08Text);
            this.ESPPanel.Controls.Add(this.label6);
            this.ESPPanel.Controls.Add(this.esp12Text);
            this.ESPPanel.Controls.Add(this.esp10Text);
            this.ESPPanel.Controls.Add(this.label8);
            this.ESPPanel.Controls.Add(this.label7);
            this.ESPPanel.Controls.Add(this.esp09Text);
            this.ESPPanel.Controls.Add(this.esp11Text);
            this.ESPPanel.Controls.Add(this.label9);
            this.ESPPanel.Controls.Add(this.label11);
            this.ESPPanel.Controls.Add(this.esp06Text);
            this.ESPPanel.Controls.Add(this.esp03Text);
            this.ESPPanel.Controls.Add(this.label10);
            this.ESPPanel.Location = new System.Drawing.Point(295, 12);
            this.ESPPanel.Name = "ESPPanel";
            this.ESPPanel.Size = new System.Drawing.Size(326, 250);
            this.ESPPanel.TabIndex = 41;
            // 
            // class40
            // 
            this.class40.Location = new System.Drawing.Point(19, 54);
            this.class40.Name = "class40";
            this.class40.Size = new System.Drawing.Size(60, 22);
            this.class40.TabIndex = 54;
            this.class40.Text = ".95";
            this.class40.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 17);
            this.label26.TabIndex = 53;
            this.label26.Text = "RSSI < 40";
            // 
            // class4050
            // 
            this.class4050.Location = new System.Drawing.Point(19, 117);
            this.class4050.Name = "class4050";
            this.class4050.Size = new System.Drawing.Size(60, 22);
            this.class4050.TabIndex = 56;
            this.class4050.Text = ".85";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 93);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(103, 17);
            this.label27.TabIndex = 55;
            this.label27.Text = "40 ≤ RSSI < 50";
            // 
            // class5060
            // 
            this.class5060.Location = new System.Drawing.Point(19, 174);
            this.class5060.Name = "class5060";
            this.class5060.Size = new System.Drawing.Size(60, 22);
            this.class5060.TabIndex = 58;
            this.class5060.Text = ".8";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 150);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 17);
            this.label28.TabIndex = 57;
            this.label28.Text = "50 ≤ RSSI < 60";
            // 
            // class6070
            // 
            this.class6070.Location = new System.Drawing.Point(19, 231);
            this.class6070.Name = "class6070";
            this.class6070.Size = new System.Drawing.Size(60, 22);
            this.class6070.TabIndex = 60;
            this.class6070.Text = ".75";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 207);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 17);
            this.label29.TabIndex = 59;
            this.label29.Text = "60 ≤ RSSI < 70";
            // 
            // class7080
            // 
            this.class7080.Location = new System.Drawing.Point(19, 286);
            this.class7080.Name = "class7080";
            this.class7080.Size = new System.Drawing.Size(60, 22);
            this.class7080.TabIndex = 62;
            this.class7080.Text = ".5";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 262);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 17);
            this.label30.TabIndex = 61;
            this.label30.Text = "70 ≤ RSSI < 80";
            // 
            // class8090
            // 
            this.class8090.Location = new System.Drawing.Point(19, 346);
            this.class8090.Name = "class8090";
            this.class8090.Size = new System.Drawing.Size(60, 22);
            this.class8090.TabIndex = 64;
            this.class8090.Text = ".3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 322);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 17);
            this.label31.TabIndex = 63;
            this.label31.Text = "80 ≤ RSSI < 90";
            // 
            // class90
            // 
            this.class90.Location = new System.Drawing.Point(19, 401);
            this.class90.Name = "class90";
            this.class90.Size = new System.Drawing.Size(60, 22);
            this.class90.TabIndex = 66;
            this.class90.Text = ".1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(16, 377);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 17);
            this.label32.TabIndex = 65;
            this.label32.Text = "90 ≤ RSSI";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label33.Location = new System.Drawing.Point(3, 5);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(141, 20);
            this.label33.TabIndex = 67;
            this.label33.Text = "Class and Weight";
            // 
            // color90
            // 
            this.color90.BackColor = System.Drawing.Color.Red;
            this.color90.ForeColor = System.Drawing.Color.Red;
            this.color90.Location = new System.Drawing.Point(85, 401);
            this.color90.Name = "color90";
            this.color90.Size = new System.Drawing.Size(33, 23);
            this.color90.TabIndex = 68;
            this.color90.UseVisualStyleBackColor = false;
            // 
            // color8090
            // 
            this.color8090.BackColor = System.Drawing.Color.OrangeRed;
            this.color8090.ForeColor = System.Drawing.Color.Red;
            this.color8090.Location = new System.Drawing.Point(85, 346);
            this.color8090.Name = "color8090";
            this.color8090.Size = new System.Drawing.Size(33, 23);
            this.color8090.TabIndex = 69;
            this.color8090.UseVisualStyleBackColor = false;
            // 
            // color7080
            // 
            this.color7080.BackColor = System.Drawing.Color.DarkOrange;
            this.color7080.ForeColor = System.Drawing.Color.Red;
            this.color7080.Location = new System.Drawing.Point(85, 286);
            this.color7080.Name = "color7080";
            this.color7080.Size = new System.Drawing.Size(33, 23);
            this.color7080.TabIndex = 70;
            this.color7080.UseVisualStyleBackColor = false;
            // 
            // color6070
            // 
            this.color6070.BackColor = System.Drawing.Color.Yellow;
            this.color6070.ForeColor = System.Drawing.Color.Red;
            this.color6070.Location = new System.Drawing.Point(85, 232);
            this.color6070.Name = "color6070";
            this.color6070.Size = new System.Drawing.Size(33, 23);
            this.color6070.TabIndex = 71;
            this.color6070.UseVisualStyleBackColor = false;
            // 
            // color5060
            // 
            this.color5060.BackColor = System.Drawing.Color.YellowGreen;
            this.color5060.ForeColor = System.Drawing.Color.Red;
            this.color5060.Location = new System.Drawing.Point(85, 173);
            this.color5060.Name = "color5060";
            this.color5060.Size = new System.Drawing.Size(33, 23);
            this.color5060.TabIndex = 72;
            this.color5060.UseVisualStyleBackColor = false;
            // 
            // color4050
            // 
            this.color4050.BackColor = System.Drawing.Color.GreenYellow;
            this.color4050.ForeColor = System.Drawing.Color.Red;
            this.color4050.Location = new System.Drawing.Point(85, 116);
            this.color4050.Name = "color4050";
            this.color4050.Size = new System.Drawing.Size(33, 23);
            this.color4050.TabIndex = 73;
            this.color4050.UseVisualStyleBackColor = false;
            // 
            // color40
            // 
            this.color40.BackColor = System.Drawing.Color.LawnGreen;
            this.color40.ForeColor = System.Drawing.Color.Red;
            this.color40.Location = new System.Drawing.Point(85, 54);
            this.color40.Name = "color40";
            this.color40.Size = new System.Drawing.Size(33, 23);
            this.color40.TabIndex = 74;
            this.color40.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 75;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 22);
            this.textBox2.TabIndex = 76;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 22);
            this.textBox3.TabIndex = 77;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(19, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 22);
            this.textBox4.TabIndex = 78;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(19, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 22);
            this.textBox5.TabIndex = 80;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(19, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 22);
            this.textBox6.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(319, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 208);
            this.panel2.TabIndex = 81;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(6, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 20);
            this.label20.TabIndex = 81;
            this.label20.Text = "Top Scores";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.color40);
            this.panel3.Controls.Add(this.color4050);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.color5060);
            this.panel3.Controls.Add(this.color6070);
            this.panel3.Controls.Add(this.color7080);
            this.panel3.Controls.Add(this.color8090);
            this.panel3.Controls.Add(this.color90);
            this.panel3.Controls.Add(this.class90);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.class8090);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.class7080);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.class6070);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.class5060);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.class4050);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.class40);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Location = new System.Drawing.Point(624, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 457);
            this.panel3.TabIndex = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.scanPanel);
            this.Controls.Add(this.scanProgress);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ESPPanel);
            this.Name = "Form1";
            this.Text = "ESP Data Collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.tryConnection);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.scanPanel.ResumeLayout(false);
            this.scanPanel.PerformLayout();
            this.ESPPanel.ResumeLayout(false);
            this.ESPPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.Label panelTitle;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label esp01Label;
        private System.Windows.Forms.TextBox esp04Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox esp07Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox esp02Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox esp05Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox esp08Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox esp10Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox esp11Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox esp12Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox esp09Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox esp06Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox esp03Text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar scanProgress;
        public System.Windows.Forms.TextBox esp01Text;
        private System.Windows.Forms.Panel scanPanel;
        private System.Windows.Forms.Button espStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox scanNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel ESPPanel;
        private System.Windows.Forms.TextBox class40;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox class4050;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox class5060;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox class6070;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox class7080;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox class8090;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox class90;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button color90;
        private System.Windows.Forms.Button color8090;
        private System.Windows.Forms.Button color7080;
        private System.Windows.Forms.Button color6070;
        private System.Windows.Forms.Button color5060;
        private System.Windows.Forms.Button color4050;
        private System.Windows.Forms.Button color40;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
    }
}

