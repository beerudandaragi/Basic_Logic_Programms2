using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class stopwatch
    {

        
            public void printWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("enter number:");
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time:{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            Console.ReadLine();
        }
      
    }

}
