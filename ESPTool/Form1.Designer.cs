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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.esp01Label = new System.Windows.Forms.Label();
            this.esp01Text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.excelPanel = new System.Windows.Forms.Panel();
            this.excelFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.excelPanel.SuspendLayout();
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
            this.connectButton.BackColor = System.Drawing.Color.LawnGreen;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(29, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 105);
            this.button1.TabIndex = 1;
            this.button1.Text = "Collect Measurements";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Copy to Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // esp01Label
            // 
            this.esp01Label.AutoSize = true;
            this.esp01Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.esp01Label.Location = new System.Drawing.Point(306, 26);
            this.esp01Label.Name = "esp01Label";
            this.esp01Label.Size = new System.Drawing.Size(65, 20);
            this.esp01Label.TabIndex = 3;
            this.esp01Label.Text = "ESP 01";
            this.esp01Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // esp01Text
            // 
            this.esp01Text.Location = new System.Drawing.Point(310, 50);
            this.esp01Text.Name = "esp01Text";
            this.esp01Text.Size = new System.Drawing.Size(75, 22);
            this.esp01Text.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(306, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ESP 04";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(306, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ESP 07";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(424, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(420, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ESP 02";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(424, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(420, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ESP 05";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(424, 171);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 22);
            this.textBox5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(420, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "ESP 08";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(310, 235);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(75, 22);
            this.textBox6.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(306, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ESP 10";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(424, 235);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(75, 22);
            this.textBox7.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(420, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "ESP 11";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(537, 235);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 22);
            this.textBox8.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(533, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "ESP 12";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(537, 171);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 22);
            this.textBox9.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(533, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "ESP 09";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(537, 108);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(75, 22);
            this.textBox10.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(533, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "ESP 06";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(537, 50);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(75, 22);
            this.textBox11.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(533, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "ESP 03";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // excelPanel
            // 
            this.excelPanel.Controls.Add(this.label12);
            this.excelPanel.Controls.Add(this.excelFile);
            this.excelPanel.Location = new System.Drawing.Point(13, 125);
            this.excelPanel.Name = "excelPanel";
            this.excelPanel.Size = new System.Drawing.Size(212, 71);
            this.excelPanel.TabIndex = 27;
            // 
            // excelFile
            // 
            this.excelFile.Location = new System.Drawing.Point(13, 33);
            this.excelFile.Name = "excelFile";
            this.excelFile.Size = new System.Drawing.Size(177, 22);
            this.excelFile.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Excel File Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 341);
            this.Controls.Add(this.excelPanel);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esp01Text);
            this.Controls.Add(this.esp01Label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "h";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.tryConnection);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.excelPanel.ResumeLayout(false);
            this.excelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.Label panelTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label esp01Label;
        private System.Windows.Forms.TextBox esp01Text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel excelPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox excelFile;
    }
}

