using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Bad
{
    public abstract class AdvancedRemote : RemoteControl
    {
        public abstract void SetChannel(int channel);   
    }
}