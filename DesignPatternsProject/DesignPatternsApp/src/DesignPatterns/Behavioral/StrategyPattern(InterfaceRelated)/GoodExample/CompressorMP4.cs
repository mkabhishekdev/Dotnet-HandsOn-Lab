using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern.GoodExample
{
    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing MP4 file...");
        }
    }
}