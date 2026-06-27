using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern.GoodExample
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("No overlay applied.");
        }
    }
}