using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beeldverwerkingswerkje
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;

        static int center_x, center_y;
        static int start_x, start_y;
        static int end_x, end_y;
 
        static int numScans = 0;
        static int linesPerScan = 0;
        static int distBetweenLines = 3;
        static int lineLength = 700;
        static int sensorDistance = 300;

        double curAngle = 0;
        double angleIncrement = 0;

        List<Point> startPoints = new List<Point>();
        Bitmap sinogram = new Bitmap(1,1);
        //Bitmap sinogram = new Bitmap("D:\\Dropbox\\3.3 CT scanner\\Sinograms\\sinogramEchteScan.png"); //Sinogram2vierkant.png    SinoSmall.png

        //Point[] startPoints = new Point[numLines];


        public Form1()
        {
            Console.WriteLine("wadds");
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            myPen.Width = 3;
            g = panel1.CreateGraphics();

            g.Clear(Color.White);

            curAngle = 0;

            start_x = center_x;
            start_y = center_y;

            //Console.WriteLine("draw");

            for (int i = 0; i < numScans; i++)
            {
                drawScan(i);
            }
            

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            Console.WriteLine(openFileDialog1.FileName.ToString());

            //sinogram = new Bitmap("D:\\Dropbox\\3.3 CT scanner\\Sinograms\\sinogramEchteScan.png");
            if (result == DialogResult.OK)
            {
                //sinogram = new Bitmap("D:\\Dropbox\\3.3 CT scanner\\Sinograms\\sinogramEchteScan.png");
                sinogram = new Bitmap(openFileDialog1.FileName.ToString());

                numScans = sinogram.Width;
                linesPerScan = sinogram.Height;

                angleIncrement = (double)180 / numScans;

                Console.WriteLine(angleIncrement);

                center_x = panel1.Width / 2;
                center_y = panel1.Height / 2;

                curAngle = 0;

                for (int i = 0; i < numScans; i++)
                {
                    //Console.WriteLine(curAngle);

                    end_x = (int)(center_x + Math.Cos(curAngle * 0.017453292519) * sensorDistance * -1);
                    end_y = (int)(center_y + Math.Sin(curAngle * 0.017453292519) * sensorDistance * -1);

                    start_x = (int)(end_x + Math.Cos((curAngle - 90) * 0.017453292519) * (distBetweenLines * (linesPerScan / 2)));
                    start_y = (int)(end_y + Math.Sin((curAngle - 90) * 0.017453292519) * (distBetweenLines * (linesPerScan / 2)));


                    startPoints.Add(new Point(start_x, start_y));

                    curAngle += angleIncrement;
                }

                Console.WriteLine(startPoints.Count);


                Console.WriteLine("width: " + sinogram.Width + " height: " + sinogram.Height);


            }

            panel1.Refresh();
        }

        private void drawScan(int i)
        {
            Point[] Points = new Point[2];


            for (int a = 0; a < linesPerScan; a++)
            {

                start_x = (int)(startPoints[i].X + Math.Cos((curAngle + 90) * 0.017453292519) * (distBetweenLines * a));
                start_y = (int)(startPoints[i].Y + Math.Sin((curAngle + 90) * 0.017453292519) * (distBetweenLines * a));

                end_x = (int)(start_x + Math.Cos(curAngle * 0.017453292519) * lineLength);
                end_y = (int)(start_y + Math.Sin(curAngle * 0.017453292519) * lineLength);

                Points[0] = new Point(start_x, start_y);
                Points[1] = new Point(end_x, end_y);

                if (sinogram.GetPixel(i, a).B == 0)
                {
                    g.DrawLines(myPen, Points);
                }
 
            }
            curAngle += angleIncrement;
        }

        private void drawLine()
        {

        }
    }
}
