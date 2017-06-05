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
        Lightsensor sensor;

        Timer homeTimer;
        Timer rotTimer;
        Timer linTimer;

        bool toTheLeftToTheLeft;
        bool ScanDone;
        bool homed;

        public int numSamplesPerLine { get; set; }
        public int numLinesPerScan { get; set; }
        public double scanDistance { get; set; }
        public int linStepDelay { get; set; }  // micros

        public int intergrationDelay { get; set; } // micros
        public int lightDelay { get; set; } // mircos

        public int sweepTime { get; set; } // micros
        public int rotTime { get; set; } // micros

        int stepsPerRot;
        int stepsPerSweep;

        int currentLine;

        List<int> scanData;

        public Scan(LinearArduino linArduino, RotatieArduino rotArduino, Lightsensor sensor,  int numSamplesPerLine, int numLinesPerScan, double scanDistance)
        {
            InitTimers();

            toTheLeftToTheLeft = true;
            ScanDone = false;
            homed = false;

            this.linArduino = linArduino;
            this.rotArduino = rotArduino;
            this.sensor = sensor;
            this.numSamplesPerLine = numSamplesPerLine;
            this.numLinesPerScan = numLinesPerScan;
            this.scanDistance = scanDistance;

            scanData = new List<int>();

            intergrationDelay = 5 * 1000;
            lightDelay = 10 * 1000;

            linStepDelay = 50;

            stepsPerRot = (32000 / (2 * numLinesPerScan));
            rotTime = ((500 + 20) * stepsPerRot);

            stepsPerSweep = Convert.ToInt32(200 * 16 * (scanDistance / 0.8));
            sweepTime = Convert.ToInt32(stepsPerSweep * (linStepDelay + 23.14336967 + (0.006068607 * linStepDelay)));


            Console.WriteLine("stepsPerRot: " + stepsPerRot + " rotTime: " + rotTime + " StepsPerSweep: " + stepsPerSweep + " sweepTime: " + sweepTime);
            Console.WriteLine("lightDelay: " + lightDelay + " total scannertime = " + lightDelay * numSamplesPerLine);

        }

        public void addLine(string[] strArr)
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                scanData.Add(Convert.ToInt32(strArr[i]));
            }
        }

        public void StartScan()
        {
            currentLine = 0;

            rotTimer.Interval = (sweepTime / 1000) + 50;
            linTimer.Interval = (rotTime / 1000) + 100;

            homeTimer.Start();

            linArduino.GoHome();
            rotArduino.GoHome();
        }

        public void StopScan()
        {
            rotTimer.Stop();
            linTimer.Stop();
            homeTimer.Stop();

            ScanDone = true;

            Console.WriteLine("STAHPHASAPS");
        }

        private void InitTimers()
        {
            homeTimer = new Timer();
            homeTimer.Tick += new EventHandler(HomeEvent);
            homeTimer.Interval = 10000;

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
            if (toTheLeftToTheLeft)
            {
                linArduino.SweepLeft(scanDistance);
            }
            else
            {
                linArduino.SweepRight(scanDistance);
            }

            sensor.GetLine(numSamplesPerLine);
            //serialPort1.WriteLine("1,11,10");

            toTheLeftToTheLeft = !toTheLeftToTheLeft;

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


                // scandata verwerken enzo
                ScanDone = true;
            }
        }

        private void HomeEvent(object sender, EventArgs e)
        {
            if (homed)
            {
                Console.WriteLine("at start pos");
                homeTimer.Stop();
                linTimer.Start();
            }
            else
            {
                homeTimer.Interval = 3000;
                linArduino.SweepLeft(7.0-(scanDistance/2));
                Console.WriteLine("HOME");
                Console.WriteLine("to start pos");
                homed = true;
            }
        }
    }
}
