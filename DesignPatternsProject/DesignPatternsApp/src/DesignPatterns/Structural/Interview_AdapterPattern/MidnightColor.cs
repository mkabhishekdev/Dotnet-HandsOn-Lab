using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Adapter
{
    public class MidnightColor : Color
    {
        public void Apply(Video video)
        {
            // Apply midnight color effect to the video
            Console.WriteLine("Applying midnight color effect to the video.");
        }
    }
}