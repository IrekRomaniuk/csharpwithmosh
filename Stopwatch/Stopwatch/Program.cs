using System;
using System.Threading;

namespace ProjetStopwatch
{
    

    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine(default(DateTime));
            // Start, Stop and Duration
            Console.WriteLine("Start, Stop and Duration");
            var stopWatch = new Stopwatch.Stopwatch1();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Duration());

            //Stop Twice
            Console.WriteLine("Stop twice");
            stopWatch.Stop();
            stopWatch.Stop();

            //Start Twice
            Console.WriteLine("Start twice");
            try
            {
                stopWatch.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Started twice {0}",ex);
            }
            


        }
    }
}
