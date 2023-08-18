using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;//timing

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
            
        }

        
        
        
        static void deneme()
        {
            Thread obj = new Thread(standart1);
            //Thread obj1 = new Thread(gauss);
            obj.Start();
            obj.Join();
            //Console.Write("\n");
            //obj1.Start();
            //

        }

        static decimal standart()
        {
            //Console.WriteLine("start");
            //Stopwatch time = new Stopwatch();
            //time.Start();
            decimal count = 0;
            for (decimal i = 1; i <= Convert.ToDecimal(Math.Pow(10, 1)); i++)
            {
                count += i;
            }
            return count;


            //Console.Write("Standart-Sonuç:" + count+"\t");
            // gauss();
            //Console.Write("\tSure:{0}", time.Elapsed.TotalSeconds);
            //time.Stop();
        }
        static void standart1(object callback)
        {
            //Stopwatch time = new Stopwatch();
            //  time.Start();
            decimal count = 0;
            for (decimal i = 1; i <= Convert.ToDecimal(Math.Pow(10, 1)); i++)
            {
                count += i;
            }
            //Console.WriteLine("\nThread"+"starting...\n");

            //Console.Write("Sonuç:" + count+"\t");
            // gauss();
            //Console.WriteLine("\nSure:{0}\n", time.Elapsed.TotalSeconds);
            //time.Stop();
        }
        static void gauss()
        {
            // Console.WriteLine("\n Gauss \n");
            // int[] array1 = new int[50];
           // Stopwatch time = new Stopwatch();
            //time.Start();

            decimal result = 0;
            decimal count = Convert.ToDecimal(Math.Pow(10, 1));
            result = (count * (count + 1)) / 2;
//            time.Stop();
            //Console.Write("Gauss: " + result + " Sure={0}", time.ElapsedMilliseconds);
            //+ "\nSure:{0}\n", time.ElapsedMilliseconds);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            decimal[] array = new decimal[33];
            Stopwatch time = new Stopwatch();
            time.Start();
            gauss();
            time.Stop();
            array[0] = time.Elapsed.Milliseconds;
            // Stopwatch time = new Stopwatch();
            time.Start();
            for (int j = 1; j <= 32; j++)
            {
                //Console.Write("\nThread {0} starting...", j);

                for (int i = 0; i < j; i++)
                {
                    deneme();
                }
                // Console.Write(standart());
                array[j] = time.Elapsed.Milliseconds;
                //Console.Write(" Sure {0}", time.Elapsed.Milliseconds);
            }

            time.Stop();
            Threads.Series["Milliseconds"].Points.AddXY(1, 264015);
            Threads.Series["Milliseconds"].Points.AddXY(2, 140524);
            Threads.Series["Milliseconds"].Points.AddXY(3, 91423);
            Threads.Series["Milliseconds"].Points.AddXY(4, 69147);
            Threads.Series["Milliseconds"].Points.AddXY(5, 57641);

            Threads.Series["Milliseconds"].Points.AddXY(6, 55197);
            Threads.Series["Milliseconds"].Points.AddXY(7, 50327);
            Threads.Series["Milliseconds"].Points.AddXY(8, 47591);
            Threads.Series["Milliseconds"].Points.AddXY(9, 46283);
            Threads.Series["Milliseconds"].Points.AddXY(10, 43679);
            Threads.Series["Milliseconds"].Points.AddXY(11, 40259);
            Threads.Series["Milliseconds"].Points.AddXY(12, 44583);
            Threads.Series["Milliseconds"].Points.AddXY(13, 38457);
            Threads.Series["Milliseconds"].Points.AddXY(14, 39476);

            Threads.Series["Milliseconds"].Points.AddXY(15, 40876);
            Threads.Series["Milliseconds"].Points.AddXY(16, 44103);
            Threads.Series["Milliseconds"].Points.AddXY(17, 37946);
            Threads.Series["Milliseconds"].Points.AddXY(18, 40169);
            Threads.Series["Milliseconds"].Points.AddXY(19, 37975);
            Threads.Series["Milliseconds"].Points.AddXY(20, 43268);
            Threads.Series["Milliseconds"].Points.AddXY(21, 38025);
            Threads.Series["Milliseconds"].Points.AddXY(22, 37978);
            Threads.Series["Milliseconds"].Points.AddXY(23, 39403);
            Threads.Series["Milliseconds"].Points.AddXY(24, 41029);
            Threads.Series["Milliseconds"].Points.AddXY(25, 36948);
            Threads.Series["Milliseconds"].Points.AddXY(26, 37139);
            Threads.Series["Milliseconds"].Points.AddXY(27, 36785);
            Threads.Series["Milliseconds"].Points.AddXY(28, 39843);
            Threads.Series["Milliseconds"].Points.AddXY(29, 37426);
            Threads.Series["Milliseconds"].Points.AddXY(30, 36387);
            Threads.Series["Milliseconds"].Points.AddXY(31, 35974);
            Threads.Series["Milliseconds"].Points.AddXY(32, 35661);
            

            /*for (int a = 1; a < 33; a++)
            {
                Threads.Series["Milliseconds"].Points.AddXY(a, 256029);
            }*/
        }
    }
}
