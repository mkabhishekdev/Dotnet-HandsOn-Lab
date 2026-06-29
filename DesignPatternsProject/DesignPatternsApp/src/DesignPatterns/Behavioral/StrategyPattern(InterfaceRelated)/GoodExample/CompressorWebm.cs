using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern.GoodExample
{
    public class CompressorWebm : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing WebM file...");
        }
    }
}