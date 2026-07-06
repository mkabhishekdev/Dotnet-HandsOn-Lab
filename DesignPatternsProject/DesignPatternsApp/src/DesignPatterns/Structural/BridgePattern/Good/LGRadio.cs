using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Good
{
    public class LGRadio : Device
    {
        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting LG Radio channel to {channel}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off LG Radio");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on LG Radio");
        }
    }
}