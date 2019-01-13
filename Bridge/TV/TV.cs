using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    abstract class TV
    {
        public IVideoSource VideoSource { get; set; }

        public abstract void ShowVideo();

        public abstract void PlayTv();
    }
}
