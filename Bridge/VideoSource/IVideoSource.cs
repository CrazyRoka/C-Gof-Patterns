using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    interface IVideoSource
    {
        string GetVideo();
        string GetProgram();
    }
}
