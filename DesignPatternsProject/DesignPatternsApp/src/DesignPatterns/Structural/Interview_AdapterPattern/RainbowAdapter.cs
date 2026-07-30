using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Structural.Adapter.Package;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Adapter
{
    public class RainbowAdapter : Rainbow, Color
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);  
        }
    }
}