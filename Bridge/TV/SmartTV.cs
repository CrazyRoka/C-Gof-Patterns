using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class SmartTV : TV
    {
        public override void ShowVideo() =>
            Console.WriteLine($"Playing video on SmartTv: \"{VideoSource.GetVideo()}\"");

        public override void PlayTv() =>
            Console.WriteLine($"Playing program on SmartTv: \"{VideoSource.GetProgram()}\"");
    }
}
