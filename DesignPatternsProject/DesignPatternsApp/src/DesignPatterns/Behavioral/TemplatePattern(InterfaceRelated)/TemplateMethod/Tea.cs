using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.TemplateMethod
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing tea for 5 mins");
        }

        protected override void AddCondiments()
        {
            if(CustomerWantsCondiments())
            {
                Console.WriteLine("Adding lemon");
            }   
            
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith("y");
        }
    }
}