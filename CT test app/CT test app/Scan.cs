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
        public int stepDelay { get; set; }  // micros
        public int intergrationTime { get; set; } // millis

        public int sweepTime { get; set; }
        public int rotTime { get; set; }

        public Scan(int numSamplesPerLine, int numLinesPerScan, double scanDistance)
        {
            this.numSamplesPerLine = numSamplesPerLine;
            this.numLinesPerScan = numLinesPerScan;
            this.scanDistance = scanDistance;
        }

        public Scan(LinearArduino linArduino, RotatieArduino rotArduino, int numSamplesPerLine, int numLinesPerScan, double scanDistance)
        {
            this.linArduino = linArduino;
            this.rotArduino = rotArduino;
            this.numSamplesPerLine = numSamplesPerLine;
            this.numLinesPerScan = numLinesPerScan;
            this.scanDistance = scanDistance;

            Console.WriteLine("Starting timer");

        }

        private void InitTimers()
        {
            homeTimer = new Timer();
            homeTimer.Tick += new EventHandler(HomeEvent);
            //homeTimer.Interval = 100;

            rotTimer = new Timer();
            rotTimer.Tick += new EventHandler(RotateEvent);
            //rotTimer.Interval = 100;

            linTimer = new Timer();
            linTimer.Tick += new EventHandler(SweepEvent);
            //linTimer.Interval = 100;

        }

        private void SweepEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Sweep");
        }

        private void RotateEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Rotate");
        }

        private void HomeEvent(object sender, EventArgs e)
        {
            Console.WriteLine("HOME");
        }
    }
}
