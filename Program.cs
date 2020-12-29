using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UdemyStopWatch
{
    class Program 
    {
        
         static void Main(String[] args) //in static canot use access modifier
         {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();
            Console.ReadKey();
            stopWatch.Stop();
            Console.ReadLine();
        }
    }

}
