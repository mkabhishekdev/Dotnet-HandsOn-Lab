using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.GoodExample
{
    public class Coffee : Beverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }

        private void Brew()
        {
            Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            if(CustomerWantsCondiments())
            {
                Console.WriteLine("Adding creamer");
            }   
            
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like creamer with your coffee (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith("y");
        }
    }
}