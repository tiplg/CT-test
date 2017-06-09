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
 
        static int numLines = 100;
        static int length = 400;

        double curAngle = 0;
        double angleIncrement = 0;

        List<Point> startPoints = new List<Point>();

        //Point[] startPoints = new Point[numLines];


        public Form1()
        {
            InitializeComponent();

            angleIncrement = (double)180 / numLines;

            Console.WriteLine(angleIncrement);

            center_x =  panel1.Width / 2;
            center_y =  panel1.Height / 2;

            curAngle = 0;

            for (int i = 0; i < numLines; i++)
            {
                //Console.WriteLine(curAngle);

                end_x = (int)(center_x + Math.Cos(curAngle * 0.017453292519) * length * -1);
                end_y = (int)(center_y + Math.Sin(curAngle * 0.017453292519) * length * -1);

                curAngle += angleIncrement;

                startPoints.Add(new Point(end_x, end_y));
            }

            Console.WriteLine(startPoints.Count);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            myPen.Width = 1;
            g = panel1.CreateGraphics();

            g.Clear(Color.Wheat);

            curAngle = 0;

            start_x = center_x;
            start_y = center_y;

            //Console.WriteLine("draw");

            for (int i = 0; i < numLines; i++)
            {
                drawLine(i);
            }
            

        }

        private void drawLine(int i)
        {

            end_x = (int)(startPoints[i].X + Math.Cos(curAngle * 0.017453292519) * length);
            end_y = (int)(startPoints[i].Y + Math.Sin(curAngle * 0.017453292519) * length);

            curAngle += angleIncrement;

            //Console.WriteLine("startpoint: " +  startPoints[i].ToString());

            Point[] Points =
             {
                startPoints[i],
                new Point(end_x, end_y)
            };

            Console.WriteLine(Points[1].ToString());

            g.DrawLines(myPen, Points);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            center_x = panel1.Width / 2;
            center_y = panel1.Height / 2;

            panel1.Refresh();
        }
    }
}
