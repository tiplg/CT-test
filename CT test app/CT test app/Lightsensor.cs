using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_test_app
{
    class Lightsensor
    {
        SerialPort serialport1;

        public Lightsensor(SerialPort serialport1)
        {
            this.serialport1 = serialport1;

        }

        public void GetLine(int samples)
        {
            serialport1.WriteLine("1,11,"+samples.ToString());
        }


    }
}
