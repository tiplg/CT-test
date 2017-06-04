using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_test_app
{
    class Scan
    {
        LinearArduino linArduino;
        RotatieArduino rotArduino;

        Timer homeTimer;
        Timer rotTimer;
        Timer linTimer;

        bool flip = true;

        public int numSamplesPerLine { get; set; }
        public int numLinesPerScan { get; set; }
        public double scanDistance { get; set; }
        public int linStepDelay { get; set; }  // micros
        public int intergrationTime { get; set; } // micros

        public int sweepTime { get; set; }
        public int rotTime { get; set; }

        int stepsPerRot;
        int stepsPerSweep;

        int currentLine;

        List<int> scanData;

        public Scan(LinearArduino linArduino, RotatieArduino rotArduino, int numSamplesPerLine, int numLinesPerScan, double scanDistance)
        {
            InitTimers();

            this.linArduino = linArduino;
            this.rotArduino = rotArduino;
            this.numSamplesPerLine = numSamplesPerLine;
            this.numLinesPerScan = numLinesPerScan;
            this.scanDistance = scanDistance;

            scanData = new List<int>();

            intergrationTime = 20000;
            linStepDelay = 50;

            stepsPerRot = (32000 / (2 * numLinesPerScan));
            rotTime = ((500 + 20) * stepsPerRot) / 1000 + 100;

            stepsPerSweep = Convert.ToInt32(200 * 16 * (scanDistance / 0.8));
            sweepTime = Convert.ToInt32(stepsPerSweep * (linStepDelay + 23.14336967 + (0.006068607 * linStepDelay))) / 1000;


            Console.WriteLine("stepsPerRot: " + stepsPerRot + " rotTime: " + rotTime + " StepsPerSweep: " + stepsPerSweep + " sweepTime: " + sweepTime);
            Console.WriteLine("intergrationTime: " + intergrationTime + "totall scanner time = " + intergrationTime * numSamplesPerLine);

        }

        public void addLine(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                scanData.Add(Convert.ToInt32(strArr[i]));
            }

            foreach (int item in scanData)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public void StartScan()
        {
            currentLine = 0;

            rotTimer.Interval = sweepTime;
            linTimer.Interval = rotTime;

            homeTimer.Start();

            linArduino.GoHome();
            rotArduino.GoHome();
        }

        private void InitTimers()
        {
            homeTimer = new Timer();
            homeTimer.Tick += new EventHandler(HomeEvent);
            homeTimer.Interval = 1000;

            rotTimer = new Timer();
            rotTimer.Tick += new EventHandler(RotateEvent);
            //rotTimer.Interval = 100;

            linTimer = new Timer();
            linTimer.Tick += new EventHandler(SweepEvent);
            //linTimer.Interval = 100;

        }

        private void SweepEvent(object sender, EventArgs e)
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

        private void RotateEvent(object sender, EventArgs e)
        {
            rotTimer.Stop();
            //
            //Console.WriteLine("rotate");

            if (++currentLine < numLinesPerScan)
            {
                rotArduino.StepLeft();
                Console.WriteLine("currentLine: " + currentLine);
                linTimer.Start();
            }
            else
            {
                Console.WriteLine("scan done");
                linTimer.Stop();
            }
        }

        private void HomeEvent(object sender, EventArgs e)
        {
            Console.WriteLine("HOME");

            homeTimer.Stop();
            linTimer.Start();
        }
    }
}
