using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Good
{
    public class SonyRadio : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting Sony Radio channel to {channel}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off Sony Radio");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on Sony Radio");
        }
    }
}