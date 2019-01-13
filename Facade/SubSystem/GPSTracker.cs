using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class GPSTracker
    {
        public bool Switch { get; set; }

        public void StartTrackingLocation()
        {
            if (Switch == false)
            {
                Console.WriteLine("Starting tracking location");
                Switch = true;
            }
            else
            {
                Console.WriteLine("Already started tracking location");
            }
        }

        public void StopTrackingLocation()
        {
            if(Switch == true)
            {
                Console.WriteLine("Stopping tracking location");
                Switch = false;
            }
            else
            {
                Console.WriteLine("Already stopped tracking location");
            }
        }
    }
}
