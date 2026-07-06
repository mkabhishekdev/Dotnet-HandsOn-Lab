using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Adapter
{
    public class BlackAndWhiteColor : Color
    {
        public void Apply(Video video)
        {
            // Apply black and white color effect to the video
            Console.WriteLine("Applying black and white color effect to the video.");
        }
    }
}