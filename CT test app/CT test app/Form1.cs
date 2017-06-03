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
        RotatieArduino rotArduino;
        Scan currentScan;

        Timer mainTimer;
        Timer homeTimer;
        Timer rotTimer;
        Timer linTimer;

        bool flip = true;
        bool atHome = false;

        public Form1()
        {
            InitializeComponent();
            InitTimers();

            accel = new Accelerometer(serialPort1);
            linArduino = new LinearArduino(serialPort1, 9, 16, 10.5);
            rotArduino = new RotatieArduino(serialPort1, 8);
        }

        private void mainLoop(object sender, EventArgs e)
        {
            //Console.WriteLine(rotatie);
            updateCT();
            updateControls();
        }

        private void rotate(object sender, EventArgs e)
        {
            rotTimer.Stop();
            //
            if (currentScan.Stepje())
            {
                rotArduino.StepLeft();
                Console.WriteLine("rotate");
                linTimer.Start();
            }
        }

        private void sweep(object sender, EventArgs e)
        {
            linTimer.Stop();
            if (flip)
            {
                linArduino.SweepLeft(6.0);
            }
            else
            {
                linArduino.SweepRight(6.0);
            }

            flip = !flip;

            Console.WriteLine("sweep");
            rotTimer.Start();
        }

        private void homed(object sender, EventArgs e)
        {

            Console.WriteLine("homed");

            if (atHome)
            {
                homeTimer.Stop();
                linTimer.Start();
            }
            else
            {
                homeTimer.Interval = 3000;
                linArduino.SweepLeft(4.0);

                atHome = true;
            }


        }


        public void InitTimers()
        {
            mainTimer = new Timer();
            mainTimer.Tick += new EventHandler(mainLoop);
            mainTimer.Interval = 100;
            mainTimer.Start();

            homeTimer = new Timer();
            homeTimer.Tick += new EventHandler(homed);
            homeTimer.Interval = 3000;


            rotTimer = new Timer();
            rotTimer.Tick += new EventHandler(rotate);

            linTimer = new Timer();
            linTimer.Tick += new EventHandler(sweep);
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
            else if (result[0] == "line")
            {
                // get line to scan object
            }
            else if (result[0] == "acc")
            {
                accel.InsertData(result[1], result[2], result[3]);
            }

            Console.Write(incommingString);

        }

        public void updateCT()
        {
            if (serialPort1.IsOpen)
            {
                /*
                if (rotatie != 0)
                {
                    int adress = 2;
                    int command = rotatie;
                    serialPort1.WriteLine(adress + "," + command + "," + "100");
                    //Console.WriteLine(adress + "," + command + "," + rotatie.ToString());
                }
                */
            }
        }

        public void updateControls()
        {
            boxAngle.Text = accel.angle.ToString("0.00");
            boxForceX.Text = accel.forceX.ToString("0.00");
            boxForceY.Text = accel.forceY.ToString("0.00");
            boxForceZ.Text = accel.forceZ.ToString("0.00");

            boxLocation.Text = linArduino.GetLocation().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);
            btnDisconnect.Enabled = false;
        }

        private void btnScanPorts_Click(object sender, EventArgs e)
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
            btnScanPorts.Enabled = false;

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
            btnScanPorts.Enabled = true;

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not so helpful error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void linHome_Click(object sender, EventArgs e)
        {
            linArduino.GoHome();
        }

        private void rotHome_Click(object sender, EventArgs e)
        {
            rotArduino.goHome();
        }

        private void rotLL_Click(object sender, EventArgs e)
        {
            rotArduino.turnLeft(1000);
        }

        private void rotLeft_Click(object sender, EventArgs e)
        {
            rotArduino.turnLeft(100);
        }

        private void rotRight_Click(object sender, EventArgs e)
        {
            rotArduino.turnRight(100);
        }

        private void rotRR_Click(object sender, EventArgs e)
        {
            rotArduino.turnRight(1000);
        }

        private void getSamples_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1,10,300");
        }

        private void linSweepLeft_Click(object sender, EventArgs e)
        {
            //linArduino.SweepLeft();
            //linArduino.SweepLeft(32000);
            linArduino.SweepLeft(6.0);
        }

        private void linSweepRight_Click(object sender, EventArgs e)
        {
            //linArduino.SweepRight();
            //linArduino.SweepRight(32000);
            linArduino.SweepRight(6.0);

        }

        private void rotStepLeft_Click(object sender, EventArgs e)
        {
            rotArduino.StepLeft();
        }

        private void rotStepRight_Click(object sender, EventArgs e)
        {
            rotArduino.StepRight();
        }

        private void linLL_Click(object sender, EventArgs e)
        {
            linArduino.SweepLeft(1000);
        }

        private void linLeft_Click(object sender, EventArgs e)
        {
            linArduino.SweepLeft(100);
        }

        private void linRight_Click(object sender, EventArgs e)
        {
            linArduino.SweepRight(100);
        }

        private void linRR_Click(object sender, EventArgs e)
        {
            linArduino.SweepRight(1000);
        }

        private void lin1LL_Click(object sender, EventArgs e)
        {
            linArduino.TurnLeft(false, 1000);
        }

        private void lin1Left_Click(object sender, EventArgs e)
        {
            linArduino.TurnLeft(false, 100);
        }

        private void lin1Right_Click(object sender, EventArgs e)
        {
            linArduino.TurnRight(false, 100);
        }

        private void lin1RR_Click(object sender, EventArgs e)
        {
            linArduino.TurnRight(false, 1000);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtSensor.Clear();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            currentScan = new Scan(50, 50, 6.0);

            currentScan.rotTime = 300;
            currentScan.sweepTime = 1500;

            rotTimer.Interval = currentScan.sweepTime;
            linTimer.Interval = currentScan.rotTime;

            homeTimer.Interval = 10000;

            homeTimer.Start();
            linArduino.GoHome();
            rotArduino.goHome();
            // go to right pos from home
        }

        private void btnSetDelay_Click(object sender, EventArgs e)
        {
            linArduino.SetStepDelay(Convert.ToInt32(numericUpDown1.Value));
        }
    }
}
