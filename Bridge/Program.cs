using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new SmartTV();

            tv.VideoSource = new CabelVideoSource();
            tv.ShowVideo();
            tv.PlayTv();

            tv.VideoSource = new WIFIVideoSource();
            tv.ShowVideo();
            tv.PlayTv();
        }
    }
}
