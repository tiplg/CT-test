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
        int microstepping { get; set; }
        int location {get; set; }
        int range;

        public LinearArduino(SerialPort serialport1, int adress, int microstepping, double range)
        {
            this.serialport1 = serialport1;
            this.adress = adress;
            this.microstepping = microstepping;
            this.range = Convert.ToInt32(200 * microstepping * (range / 0.8));

        }

        public double GetLocation() {
            return (location / 200.0 / microstepping) * 0.8;
        }


        public void blinkled(int time)
        {
            serialport1.WriteLine(adress + ",2," + time.ToString());
        }

        public void GoHome()
        {
            serialport1.WriteLine(adress + ",20,0");
            location = 0;
        }

        public void SetStepDelay(int stepDelay)
        {
            serialport1.Write(adress + ",3," + stepDelay);
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
            steps = checkOutOfRange(false, steps);
            serialport1.WriteLine(adress + ",14," + steps);
        }

        public void SweepRight(int steps)
        {
            steps = checkOutOfRange(true, steps);
            serialport1.WriteLine(adress + ",15," + steps);
        }

        public void SweepLeft(double cm)
        {
            int steps = Convert.ToInt32(200 * microstepping * (cm / 0.8));
            Console.WriteLine("steps wanted: " + steps);
            steps = checkOutOfRange(false,steps);
            Console.WriteLine("steps send: " + steps);
            serialport1.WriteLine(adress + ",14," + steps);
        }

        public void SweepRight(double cm)
        {
            int steps = Convert.ToInt32(200 * microstepping * (cm / 0.8));
            Console.WriteLine("steps wanted: " + steps);
            steps = checkOutOfRange(true, steps);
            Console.WriteLine("steps send: " + steps);
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

        int checkOutOfRange(bool direction, int steps)
        {
            int temp = 0;
            if (direction)
            {
                if ((location - steps) < 0)
                {
                    temp = location;
                    location = 0;
                    return temp;
                }
                else
                {
                    location -= steps;
                    return steps;
                }
            }
            else
            {
                if ((location + steps) > range)
                {
                    temp = (range - location);
                    location = range;
                    return temp;
                }
                else
                {
                    location += steps;
                    return steps;
                }
            }
        }
    }
}
