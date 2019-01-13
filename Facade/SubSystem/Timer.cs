using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Timer
    {
        public bool Switch { get; set; }

        public void StartTrackingTime()
        {
            if (Switch == false)
            {
                Console.WriteLine("Starting timer");
                Switch = true;
            }
            else
            {
                Console.WriteLine("Already started timer");
            }
        }

        public void StopTrackingTime()
        {
            if (Switch == true)
            {
                Console.WriteLine("Stopping timer");
                Switch = false;
            }
            else
            {
                Console.WriteLine("Already stopped timer");
            }
        }
    }
}
