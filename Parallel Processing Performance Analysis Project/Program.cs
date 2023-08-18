using System;
using System.Threading;
using System.Diagnostics;//timing

class HelloWorld
{
    //static int[] array = new int[100];

    static void Main()
    {

        gauss();
        Stopwatch time = new Stopwatch();
       
        for (int j = 1; j <= 32; j++)
        { 
            time.Start();
            Console.Write("\nThread {0} starting...", j);
            
            for (int i = 0; i < j; i++)
            {
                
                deneme();
            }
            Console.Write(standart());
             time.Stop();
            Console.Write(" Sure {0}", time.Elapsed.TotalMilliseconds);
        }
       

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
            for (decimal i = 1; i <= Convert.ToDecimal(Math.Pow(10, 10)); i++)
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
            for (decimal i = 1; i <= Convert.ToDecimal(Math.Pow(10, 10)); i++)
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
            decimal count = Convert.ToDecimal(Math.Pow(10,10));
            result = (count * (count + 1)) / 2;
            //time.Stop();
            Console.Write("Gauss: " + result+" Sure={0}");
            //+ "\nSure:{0}\n", time.ElapsedMilliseconds);

        }


    
}


