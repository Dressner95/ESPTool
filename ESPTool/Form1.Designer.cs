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
            this.panel1.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.tryConnection);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.Label panelTitle;
    }
}

