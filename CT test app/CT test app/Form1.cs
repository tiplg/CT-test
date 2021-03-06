﻿using System;
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
        Lightsensor sensor;
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
            sensor = new Lightsensor(serialPort1);
            linArduino = new LinearArduino(serialPort1, 9, 16, 10.5);
            rotArduino = new RotatieArduino(serialPort1, 8);

            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    item.Enabled = false;
                }
            }

            //currentScan = new Scan(linArduino, rotArduino, sensor, 10, 10, 6.0);
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
            if (true)
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
            while (serialPort1.BytesToRead > 1) {
                string incommingString = serialPort1.ReadLine();
                string[] result;
                char[] sep = { ',','\n',' '};
            
                result = incommingString.Split(sep);

            if(result[0] == "lux")
            {
                SetText(result[1]);
            }
            else if (result[0] == "line")
            {
                    // get line to scan object
                    currentScan.addLine(result.Skip(1).ToArray());
            }
            else if (result[0] == "acc")
            {
                accel.InsertData(result[1], result[2], result[3]);
            }

            Console.Write(incommingString);
            }


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


            try
            {
                serialPort1.PortName = cboPorts.Text;
                serialPort1.Open();

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                cboPorts.Enabled = false;
                btnScanPorts.Enabled = false;

                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        item.Enabled = true;
                    }
                }
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


            try
            {
                serialPort1.Close();

                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                cboPorts.Enabled = true;
                btnScanPorts.Enabled = true;

                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox)
                    {
                        item.Enabled = false;
                    }
                }

                currentScan.StopScan();
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
            rotArduino.GoHome();
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
            serialPort1.WriteLine("1,10,10");
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

            currentScan = new Scan(linArduino, rotArduino, sensor, Convert.ToInt32(UDSamples.Value), Convert.ToInt32(UDLines.Value), (double)UDcm.Value);

            currentScan.StartScan();

            //currentScan.rotTime = 300;
            //currentScan.sweepTime = 1500;

            //rotTimer.Interval = currentScan.sweepTime;
            //linTimer.Interval = currentScan.rotTime;

            //homeTimer.Interval = 10000;

            //homeTimer.Start();
            //linArduino.GoHome();
            //rotArduino.goHome();
            // go to right pos from home
        }

        private void btnSetDelay_Click(object sender, EventArgs e)
        {
            linArduino.SetStepDelay(Convert.ToInt32(numericUpDown1.Value));
        }

        private void btnSetLightDelay_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1,3," + (numericUpDown2.Value * 1000).ToString());
            //Console.WriteLine("1,3," + (numericUpDown2.Value * 1000).ToString());
        }

        private void btnSetIntergrationTime_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1,4," + (numericUpDown3.Value*1000).ToString());
            //Console.WriteLine("1,4," + (numericUpDown3.Value * 1000).ToString());
        }

        private void btnGetLine_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("1,11,10");
            sensor.GetLine(10);
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            currentScan.StopScan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = currentScan.sinogram;
            
        }
    }
}
