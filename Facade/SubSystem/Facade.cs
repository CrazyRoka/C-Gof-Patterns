using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Facade
    {
        public void GoJogging()
        {
            GPSTracker tracker = new GPSTracker();
            Timer timer = new Timer();

            Console.WriteLine("Enabling tracking devices");
            tracker.StartTrackingLocation();
            timer.StartTrackingTime();

            Console.WriteLine("Starting jogging");

            tracker.StopTrackingLocation();
            timer.StopTrackingTime();
            Console.WriteLine("Finished jogging. Trackers stopped");
        }
    }
}
