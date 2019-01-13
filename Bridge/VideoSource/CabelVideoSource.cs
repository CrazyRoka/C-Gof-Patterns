using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class CabelVideoSource : IVideoSource
    {
        public string GetVideo() => "I am using cabel to get video";

        public string GetProgram() => "I am using cabel to get program";
    }
}
