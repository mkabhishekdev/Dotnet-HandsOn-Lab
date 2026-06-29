using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.GoodExample
{
    public class Tea : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing tea");
        }

        private void AddCondiments()
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