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

namespace CT_test_app
{
    public partial class Form1 : Form
    {
        private Timer mainTimer;

        int rotatie = 0;

        public Form1()
        {
            InitializeComponent();
            InitTimer();
        }

        private void mainLoop(object sender, EventArgs e)
        {
            //Console.WriteLine(rotatie);
            updateCT();
        }

        public void InitTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(mainLoop);
            mainTimer.Interval = 1000;
            mainTimer.Start();
        }

        public void updateCT()
        {
            if (serialPort1.IsOpen)
            {
                byte[] outBuffer = new byte[3];
                outBuffer[0] = 1;
                outBuffer[1] = 1;
                outBuffer[2] = (byte)rotatie;
                serialPort1.Write(outBuffer, 0, 3);
                Console.WriteLine(outBuffer[2].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);
            btnDisconnect.Enabled = false;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            cboPorts.Enabled = false;
            btnScan.Enabled = false;

            try
            {
                serialPort1.PortName = cboPorts.Text;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                cboPorts.Enabled = true;
                MessageBox.Show(ex.Message, "Not so helpful error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            cboPorts.Enabled = true;
            btnScan.Enabled = true;

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not so helpful error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rotLeft_MouseDown(object sender, MouseEventArgs e)
        {
            rotatie = 1;
        }

        private void rotLeft_MouseUp(object sender, MouseEventArgs e)
        {
            rotatie = 0;
        }

        private void rotRight_MouseDown(object sender, MouseEventArgs e)
        {
            rotatie = 2;
        }

        private void rotRight_MouseUp(object sender, MouseEventArgs e)
        {
            rotatie = 0;
        }
    }
}
