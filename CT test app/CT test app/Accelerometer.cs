using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_test_app
{
    class Accelerometer
    {
        SerialPort serialport1;

        bool newData { get; set; }

        public double forceX { get; set; }
        public double forceY { get; set; }
        public double forceZ { get; set; }

        public int rawX { get; set; }
        public int rawY { get; set; }
        public int rawZ { get; set; }

        public double angle { get; set; }

        public Accelerometer(SerialPort serialport1)
        {
            this.serialport1 = serialport1;

            newData = false;

            forceX = 0;
            forceY = 0;
            forceZ = 0;

            angle = 0;
        }

        public void InsertData(String xString, String yString, String zString)
        {
            rawX = Convert.ToInt32(xString);
            rawY = Convert.ToInt32(yString);
            rawZ = Convert.ToInt32(zString);

            forceX = rawX / 16384.0;
            forceY = rawY / 16384.0;
            forceZ = rawZ / 16384.0;

            angle = (Math.Atan2(forceX, forceZ) * 57.2958) + 180;

            newData = true;
        }

    }
}
