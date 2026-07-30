using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Adapter.Package
{
    public class Rainbow
    {
        public void Setup()
        {
            // Setup rainbow effect for the video
            Console.WriteLine("Setting up rainbow effect for the video.");
        }

        public void Update(Video video)
        {
            // Update the video with rainbow effect
            Console.WriteLine("Updating the video with rainbow effect.");
        }
    }
}