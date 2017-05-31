using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;

namespace CT_test_app
{
    class LinearArduino
    {
        SerialPort serialport1;
        int adress { get; set; }
        public LinearArduino(SerialPort serialport1, int adress)
        {
            this.serialport1 = serialport1;
            this.adress = adress;
        }

        public void blinkled(int time)
        {
            serialport1.WriteLine(adress + ",2," + time.ToString());
        }

        public void GoHome()
        {
            serialport1.WriteLine(adress + ",20,0");
        }

        public void SweepLeft()
        {
            serialport1.WriteLine(adress + ",21,0");
        }

        public void SweepRight()
        {
            serialport1.WriteLine(adress + ",22,0");
        }

        public void SweepLeft(int steps)
        {
            serialport1.WriteLine(adress + ",14," + steps);
        }

        public void SweepRight(int steps)
        {
            serialport1.WriteLine(adress + ",15," + steps);
        }

        public void TurnLeft(bool side, int steps)
        {
            int command;
            if (side)
            {
                command = 10;
            }
            else
            {
                command = 12;
            }

            serialport1.WriteLine(adress + "," + command + "," + steps);

        }

        public void TurnRight(bool side, int steps)
        {
            int command;
            if (side)
            {
                command = 11;
            }
            else
            {
                command = 13;
            }

            serialport1.WriteLine(adress + "," + command + "," + steps);
        }

    }
}
