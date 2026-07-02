using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern.GoodSolution
{
    public class Logger : Handler
    {
        public override bool CanHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");
            return false;
        }
    }
}