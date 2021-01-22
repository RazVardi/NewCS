using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UdemyStopWatch
{
    class ProgramStopper //main class
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
    public class StopWatch
    {   
        DateTime initialTime;
        bool b = true;
        
        public void Start()
        {
            if (b)
            {
                initialTime = DateTime.Now;
                b = false;
            }
            else
            {
                throw new InvalidOperationException("start  already running");
            }  
        }
        
        public void Stop()
        {
            if (!b)
            {
                TimeSpan duration = (DateTime.Now - initialTime);
                Console.WriteLine(duration);
                bool b = true;
            }
            else
            {
                throw new InvalidOperationException("stop already running");
            }
           
        }
    }

}
