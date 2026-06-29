using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing MOV file...");
        }
    }
}