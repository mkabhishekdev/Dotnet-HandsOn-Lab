using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Good
{
    public interface Device
    {
        public void TurnOn();
        public void TurnOff();
        public void SetChannel(int channel);    
    }
}