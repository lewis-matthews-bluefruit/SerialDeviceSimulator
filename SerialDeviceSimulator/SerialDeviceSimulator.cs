using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using SimulatedDevice = SerialDeviceSimulator.DeviceValues;
using ID = SerialDeviceSimulator.ModuleID;

namespace SerialDeviceSimulator
{
    public partial class SerialDeviceSimulator : Form
    {
        public SerialDeviceSimulator()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboPorts.Text;
                serialPort1.BaudRate = Int32.Parse(cboBaud.Text);
                serialPort1.DtrEnable = true;
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                if (serialPort1.IsOpen)
                {
                    connectionValid.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectionValid.BackColor = Color.DarkGray;
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            this.Invoke(new MethodInvoker(delegate ()
            {
                serialReceivedTextbox.AppendText(sp.ReadExisting());
            }));
        }

        private void baudRateSet_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = Int32.Parse(cboBaud.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialDeviceSimulator_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length > 0)
            {
                cboPorts.Items.AddRange(ports);
                cboPorts.SelectedIndex = 0;
                cboBaud.SelectedIndex = 9;
            }
            CRCRefresh();
        }

        public string SetVaules()
        {
            SimulatedDevice.Value1 = value1Textbox.Text;

            string Values = SimulatedDevice.Value1 + ",";
            return Values;

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialSentTextbox.AppendText(SetVaules() + CRCValue() + Environment.NewLine);
                    serialPort1.WriteLine(SetVaules() + CRCValue());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string previewText()
        {
            string previewText = "Value 1 = " + SetVaules() + "\n CRC = " + CRCValue();

            return previewText;
        }

        public string CRCValue()
        {
            string CRCValues = crcCodeTextbox.Text;
            return CRCValues;
        }

        public void CRCRefresh()
        {
            string serialDeviceData = SetVaules();

            UInt32 checksum = 0;

            for (UInt32 i = 0; i < serialDeviceData.Length; i++)
            {
                checksum = CRC32.CalculateCRC32(checksum, Convert.ToByte(serialDeviceData[checked((int)i)]));
            }
            
            crcCodeTextbox.Text = checksum.ToString("X8");
        }

        private void value1_TextChanged(object sender, EventArgs e)
        {
            CRCRefresh();
        }
    }
}