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
            Console.WriteLine(adress.ToString() + ",2," + time.ToString());
        }

    }
}
