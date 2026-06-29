using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.GoodExample
{
    public class Chamomile : Beverage
    {
        public void Prepare()
        {
            Brew();
        }

        public void Brew()
        {
            Console.WriteLine("Brewing for 3 minutes");
        }
    }
}