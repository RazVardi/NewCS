using System;

namespace UdemyStopWatch
{
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











