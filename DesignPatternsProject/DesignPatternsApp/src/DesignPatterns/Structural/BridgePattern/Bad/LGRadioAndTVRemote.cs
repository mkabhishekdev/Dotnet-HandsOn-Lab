using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.BridgePattern.Bad
{
    public class LGRadioAndTVRemote : RadioAndTVRemote
    {
        public override void ControlRadio()
        {
            Console.WriteLine("Controlling LG Radio.");
        }

        public override void ControlTV()
        {
            Console.WriteLine("Controlling LG TV.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("LG Radio and TV are turned off.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("LG Radio and TV are turned on.");
        }

        public override void VolumeDown()
        {
            Console.WriteLine("LG Radio and TV volume is decreased.");
        }

        public override void VolumeUp()
        {
            Console.WriteLine("LG Radio and TV volume is increased.");
        }
    }
}