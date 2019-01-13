using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class WIFIVideoSource : IVideoSource
    {
        public string GetVideo() => "I am using WIFI to get video";

        public string GetProgram() => "I am using WIFI to get program";
    }
}
