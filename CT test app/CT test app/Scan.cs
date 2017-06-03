using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_test_app
{
    class Scan
    {
        public int numSamplesPerLine { get; set; }
        public int numLinesPerScan { get; set; }
        public double scanDistance { get; set; }
        public int stepDelay { get; set; }  // micros
        public int intergrationTime { get; set; } // millis

        public int sweepTime { get; set; }
        public int rotTime { get; set; }

        int currentLine;

        public Scan(int numSamplesPerLine, int numLinesPerScan, double scanDistance)
        {
            this.numSamplesPerLine = numSamplesPerLine;
            this.numLinesPerScan = numLinesPerScan;
            this.scanDistance = scanDistance;

            currentLine = 0;
        }

        public bool Stepje()
        {
            if(++currentLine >= numLinesPerScan)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
