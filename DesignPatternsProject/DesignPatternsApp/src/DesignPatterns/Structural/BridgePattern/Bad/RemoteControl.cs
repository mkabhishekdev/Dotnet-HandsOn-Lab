using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Bad
{
    public abstract class RemoteControl
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void VolumeUp();
        public abstract void VolumeDown();
    }
}