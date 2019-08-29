namespace SerialDeviceSimulator
{
    partial class SerialDeviceSimulator
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
            this.components = new System.ComponentModel.Container();
            this.connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.value1Textbox = new System.Windows.Forms.TextBox();
            this.value1Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.baudRateSet = new System.Windows.Forms.Button();
            this.connectionValid = new System.Windows.Forms.Panel();
            this.crcCodeTextbox = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.serialReceivedTextbox = new System.Windows.Forms.RichTextBox();
            this.serialReceivedLabel = new System.Windows.Forms.Label();
            this.serialSentTextbox = new System.Windows.Forms.RichTextBox();
            this.serialSentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.Location = new System.Drawing.Point(139, 49);
            this.connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(99, 28);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect To Port";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(15, 54);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(118, 21);
            this.cboPorts.TabIndex = 2;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(139, 146);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(99, 28);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // value1Textbox
            // 
            this.value1Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Textbox.Location = new System.Drawing.Point(12, 151);
            this.value1Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.value1Textbox.Name = "value1Textbox";
            this.value1Textbox.Size = new System.Drawing.Size(121, 20);
            this.value1Textbox.TabIndex = 4;
            this.value1Textbox.Text = "6000";
            this.value1Textbox.TextChanged += new System.EventHandler(this.value1_TextChanged);
            // 
            // value1Label
            // 
            this.value1Label.AutoSize = true;
            this.value1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value1Label.Location = new System.Drawing.Point(12, 134);
            this.value1Label.Name = "value1Label";
            this.value1Label.Size = new System.Drawing.Size(46, 13);
            this.value1Label.TabIndex = 5;
            this.value1Label.Text = "Value 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Port:";
            // 
            // cboBaud
            // 
            this.cboBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "38400",
            "19200",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cboBaud.Location = new System.Drawing.Point(318, 54);
            this.cboBaud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(118, 21);
            this.cboBaud.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(315, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Baud rate:";
            // 
            // baudRateSet
            // 
            this.baudRateSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateSet.Location = new System.Drawing.Point(442, 49);
            this.baudRateSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baudRateSet.Name = "baudRateSet";
            this.baudRateSet.Size = new System.Drawing.Size(99, 28);
            this.baudRateSet.TabIndex = 26;
            this.baudRateSet.Text = "Set Baud Rate";
            this.baudRateSet.UseVisualStyleBackColor = true;
            this.baudRateSet.Click += new System.EventHandler(this.baudRateSet_Click);
            // 
            // connectionValid
            // 
            this.connectionValid.BackColor = System.Drawing.Color.DarkGray;
            this.connectionValid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionValid.Location = new System.Drawing.Point(244, 49);
            this.connectionValid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectionValid.Name = "connectionValid";
            this.connectionValid.Size = new System.Drawing.Size(26, 28);
            this.connectionValid.TabIndex = 100;
            // 
            // crcCodeTextbox
            // 
            this.crcCodeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crcCodeTextbox.Location = new System.Drawing.Point(12, 246);
            this.crcCodeTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crcCodeTextbox.Name = "crcCodeTextbox";
            this.crcCodeTextbox.Size = new System.Drawing.Size(121, 20);
            this.crcCodeTextbox.TabIndex = 191;
            this.crcCodeTextbox.Text = "0";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(12, 229);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(32, 13);
            this.label97.TabIndex = 192;
            this.label97.Text = "CRC:";
            // 
            // serialReceivedTextbox
            // 
            this.serialReceivedTextbox.HideSelection = false;
            this.serialReceivedTextbox.Location = new System.Drawing.Point(12, 434);
            this.serialReceivedTextbox.Name = "serialReceivedTextbox";
            this.serialReceivedTextbox.ReadOnly = true;
            this.serialReceivedTextbox.Size = new System.Drawing.Size(762, 89);
            this.serialReceivedTextbox.TabIndex = 222;
            this.serialReceivedTextbox.Text = "";
            // 
            // serialReceivedLabel
            // 
            this.serialReceivedLabel.AutoSize = true;
            this.serialReceivedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialReceivedLabel.Location = new System.Drawing.Point(12, 418);
            this.serialReceivedLabel.Name = "serialReceivedLabel";
            this.serialReceivedLabel.Size = new System.Drawing.Size(151, 13);
            this.serialReceivedLabel.TabIndex = 223;
            this.serialReceivedLabel.Text = "Received data from serial port:";
            // 
            // serialSentTextbox
            // 
            this.serialSentTextbox.HideSelection = false;
            this.serialSentTextbox.Location = new System.Drawing.Point(12, 306);
            this.serialSentTextbox.Name = "serialSentTextbox";
            this.serialSentTextbox.ReadOnly = true;
            this.serialSentTextbox.Size = new System.Drawing.Size(762, 89);
            this.serialSentTextbox.TabIndex = 224;
            this.serialSentTextbox.Text = "";
            // 
            // serialSentLabel
            // 
            this.serialSentLabel.AutoSize = true;
            this.serialSentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialSentLabel.Location = new System.Drawing.Point(12, 290);
            this.serialSentLabel.Name = "serialSentLabel";
            this.serialSentLabel.Size = new System.Drawing.Size(116, 13);
            this.serialSentLabel.TabIndex = 225;
            this.serialSentLabel.Text = "Data sent to serial port:";
            // 
            // SerialDeviceSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 535);
            this.Controls.Add(this.serialSentLabel);
            this.Controls.Add(this.serialSentTextbox);
            this.Controls.Add(this.serialReceivedLabel);
            this.Controls.Add(this.serialReceivedTextbox);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.crcCodeTextbox);
            this.Controls.Add(this.connectionValid);
            this.Controls.Add(this.baudRateSet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboBaud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.value1Label);
            this.Controls.Add(this.value1Textbox);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.connect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SerialDeviceSimulator";
            this.Text = "Serial Device Simulator";
            this.Load += new System.EventHandler(this.SerialDeviceSimulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox value1Textbox;
        private System.Windows.Forms.Label value1Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button baudRateSet;
        private System.Windows.Forms.Panel connectionValid;
        private System.Windows.Forms.TextBox crcCodeTextbox;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.RichTextBox serialReceivedTextbox;
        private System.Windows.Forms.Label serialReceivedLabel;
        private System.Windows.Forms.RichTextBox serialSentTextbox;
        private System.Windows.Forms.Label serialSentLabel;
    }
}

