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
            this.panel1.SuspendLayout();
            this.scanPanel.SuspendLayout();
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
            this.scanButton.Location = new System.Drawing.Point(29, 224);
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
            this.copyButton.Location = new System.Drawing.Point(372, 285);
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
            this.esp01Label.Location = new System.Drawing.Point(306, 41);
            this.esp01Label.Name = "esp01Label";
            this.esp01Label.Size = new System.Drawing.Size(65, 20);
            this.esp01Label.TabIndex = 3;
            this.esp01Label.Text = "ESP 01";
            // 
            // esp01Text
            // 
            this.esp01Text.Location = new System.Drawing.Point(310, 65);
            this.esp01Text.Name = "esp01Text";
            this.esp01Text.Size = new System.Drawing.Size(75, 22);
            this.esp01Text.TabIndex = 4;
            // 
            // esp04Text
            // 
            this.esp04Text.Location = new System.Drawing.Point(310, 123);
            this.esp04Text.Name = "esp04Text";
            this.esp04Text.Size = new System.Drawing.Size(75, 22);
            this.esp04Text.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(306, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ESP 04";
            // 
            // esp07Text
            // 
            this.esp07Text.Location = new System.Drawing.Point(310, 186);
            this.esp07Text.Name = "esp07Text";
            this.esp07Text.Size = new System.Drawing.Size(75, 22);
            this.esp07Text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(306, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ESP 07";
            // 
            // esp02Text
            // 
            this.esp02Text.Location = new System.Drawing.Point(424, 65);
            this.esp02Text.Name = "esp02Text";
            this.esp02Text.Size = new System.Drawing.Size(75, 22);
            this.esp02Text.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(420, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ESP 02";
            // 
            // esp05Text
            // 
            this.esp05Text.Location = new System.Drawing.Point(424, 123);
            this.esp05Text.Name = "esp05Text";
            this.esp05Text.Size = new System.Drawing.Size(75, 22);
            this.esp05Text.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(420, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ESP 05";
            // 
            // esp08Text
            // 
            this.esp08Text.Location = new System.Drawing.Point(424, 186);
            this.esp08Text.Name = "esp08Text";
            this.esp08Text.Size = new System.Drawing.Size(75, 22);
            this.esp08Text.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(420, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ESP 08";
            // 
            // esp10Text
            // 
            this.esp10Text.Location = new System.Drawing.Point(310, 250);
            this.esp10Text.Name = "esp10Text";
            this.esp10Text.Size = new System.Drawing.Size(75, 22);
            this.esp10Text.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(306, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ESP 10";
            // 
            // esp11Text
            // 
            this.esp11Text.Location = new System.Drawing.Point(424, 250);
            this.esp11Text.Name = "esp11Text";
            this.esp11Text.Size = new System.Drawing.Size(75, 22);
            this.esp11Text.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(420, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "ESP 11";
            // 
            // esp12Text
            // 
            this.esp12Text.Location = new System.Drawing.Point(537, 250);
            this.esp12Text.Name = "esp12Text";
            this.esp12Text.Size = new System.Drawing.Size(75, 22);
            this.esp12Text.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(533, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "ESP 12";
            // 
            // esp09Text
            // 
            this.esp09Text.Location = new System.Drawing.Point(537, 186);
            this.esp09Text.Name = "esp09Text";
            this.esp09Text.Size = new System.Drawing.Size(75, 22);
            this.esp09Text.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(533, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "ESP 09";
            // 
            // esp06Text
            // 
            this.esp06Text.Location = new System.Drawing.Point(537, 123);
            this.esp06Text.Name = "esp06Text";
            this.esp06Text.Size = new System.Drawing.Size(75, 22);
            this.esp06Text.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(533, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "ESP 06";
            // 
            // esp03Text
            // 
            this.esp03Text.Location = new System.Drawing.Point(537, 65);
            this.esp03Text.Name = "esp03Text";
            this.esp03Text.Size = new System.Drawing.Size(75, 22);
            this.esp03Text.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(533, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "ESP 03";
            // 
            // scanProgress
            // 
            this.scanProgress.Location = new System.Drawing.Point(310, 12);
            this.scanProgress.Maximum = 10;
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(302, 23);
            this.scanProgress.Step = 1;
            this.scanProgress.TabIndex = 28;
            // 
            // scanPanel
            // 
            this.scanPanel.Controls.Add(this.espStatus);
            this.scanPanel.Controls.Add(this.label13);
            this.scanPanel.Controls.Add(this.scanNumber);
            this.scanPanel.Controls.Add(this.label12);
            this.scanPanel.Location = new System.Drawing.Point(13, 125);
            this.scanPanel.Name = "scanPanel";
            this.scanPanel.Size = new System.Drawing.Size(276, 81);
            this.scanPanel.TabIndex = 29;
            // 
            // espStatus
            // 
            this.espStatus.BackColor = System.Drawing.Color.Red;
            this.espStatus.Location = new System.Drawing.Point(145, 4);
            this.espStatus.Name = "espStatus";
            this.espStatus.Size = new System.Drawing.Size(128, 74);
            this.espStatus.TabIndex = 3;
            this.espStatus.Text = "espStatus";
            this.espStatus.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Scan Number";
            // 
            // scanNumber
            // 
            this.scanNumber.Location = new System.Drawing.Point(13, 56);
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
            this.label12.Location = new System.Drawing.Point(9, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Scan Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 341);
            this.Controls.Add(this.scanPanel);
            this.Controls.Add(this.scanProgress);
            this.Controls.Add(this.esp12Text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.esp09Text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.esp06Text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.esp03Text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.esp11Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.esp10Text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.esp08Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.esp05Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.esp02Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.esp07Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.esp04Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esp01Text);
            this.Controls.Add(this.esp01Label);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ESP Data Collector";
            this.Click += new System.EventHandler(this.tryConnection);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.scanPanel.ResumeLayout(false);
            this.scanPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

