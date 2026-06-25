using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.DependencyInversionPrinciple
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine started.");
        }
    }
}