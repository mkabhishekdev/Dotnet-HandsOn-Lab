using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Bad
{
    public class AdvancedLGRemote : AdvancedRemote
    {
        public override void SetChannel(int channel)
        {
            Console.WriteLine($"LG TV channel is set to {channel}.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("LG TV is turned off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("LG TV is turned on.");
        }

        public override void VolumeDown()
        {
            Console.WriteLine("LG TV volume is decreased.");
        }

        public override void VolumeUp()
        {
            Console.WriteLine("LG TV volume is increased.");
        }
    }
}