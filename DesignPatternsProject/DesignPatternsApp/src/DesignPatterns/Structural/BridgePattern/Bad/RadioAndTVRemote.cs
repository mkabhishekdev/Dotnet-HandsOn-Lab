using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Bad
{
    public abstract class RadioAndTVRemote : RemoteControl
    {
        public abstract void ControlTV();
        public abstract void ControlRadio();
    }
}