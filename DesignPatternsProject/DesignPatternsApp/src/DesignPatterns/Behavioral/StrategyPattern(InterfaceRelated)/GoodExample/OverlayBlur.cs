using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern.GoodExample
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            Console.WriteLine("Applying Blur overlay...");
        }
    }
}