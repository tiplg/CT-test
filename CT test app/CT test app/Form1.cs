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
        delegate void SetTextCallback(string text);

        Accelerometer accel;
        LinearArduino linArduino;

        private Timer mainTimer;

        int rotatie = 0;

        public Form1()
        {
            InitializeComponent();
            InitTimer();

            accel = new Accelerometer(serialPort1);
            linArduino = new LinearArduino(serialPort1, 9);
        }

        private void mainLoop(object sender, EventArgs e)
        {
            //Console.WriteLine(rotatie);
            updateCT();
            updateControls();
        }

        public void InitTimer()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(mainLoop);
            mainTimer.Interval = 100;
            mainTimer.Start();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string[] result;
            char[] sep = { ',', '\n',' '};
            string incommingString = serialPort1.ReadLine();
            result = incommingString.Split(sep);

            if(result[0] == "lux")
            {
                SetText(result[1]);
            }
            else if (result[0] == "acc")
            {
                //int x = Convert.ToInt32(result[1]);
                accel.InsertData(result[1], result[2], result[3]);
                //Console.WriteLine(accel.angle);

                //Console.WriteLine("x: " + accel.forceX.ToString() + " y: " + accel.forceY.ToString() + " z: " + accel.forceZ.ToString());

                
            }
            //Console.WriteLine(result[0]) ;
            

            //Console.Write(incommingString);

        }

        public void updateCT()
        {
            if (serialPort1.IsOpen)
            {
                if (rotatie != 0)
                {
                    int adress = 2;
                    int command = rotatie;
                    serialPort1.WriteLine(adress + "," + command + "," + "100");
                    //Console.WriteLine(adress + "," + command + "," + rotatie.ToString());
                }
                
                //
            }
        }

        public void updateControls()
        {
            boxAngle.Text = accel.angle.ToString("0.00");
            boxForceX.Text = accel.forceX.ToString("0.00");
            boxForceY.Text = accel.forceY.ToString("0.00");
            boxForceZ.Text = accel.forceZ.ToString("0.00");
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
            rotatie = 10;
        }

        private void rotLeft_MouseUp(object sender, MouseEventArgs e)
        {
            rotatie = 0;
        }

        private void rotRight_MouseDown(object sender, MouseEventArgs e)
        {
            rotatie = 11;
        }

        private void rotRight_MouseUp(object sender, MouseEventArgs e)
        {
            rotatie = 0;
        }

        private void SetText(string text)
        {
            if (this.txtSensor.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtSensor.AppendText(text);
            }
        }

        private void rotLeft_Click(object sender, EventArgs e)
        {

        }

        private void rotLL_Click(object sender, EventArgs e)
        {
            linArduino.blinkled(500);
        }


    }
}
