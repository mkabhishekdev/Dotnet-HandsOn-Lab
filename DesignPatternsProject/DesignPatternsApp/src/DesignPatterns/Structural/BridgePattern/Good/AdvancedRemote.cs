using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Good
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(Device device) : base(device)
        {
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting channel to {channel}");
        }
    }
}