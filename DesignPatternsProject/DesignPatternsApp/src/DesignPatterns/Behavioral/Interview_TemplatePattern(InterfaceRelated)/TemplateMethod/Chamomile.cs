using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.TemplateMethod
{
    public class Chamomile : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brew chamomile for 2 mins");
        }

        
    }
}