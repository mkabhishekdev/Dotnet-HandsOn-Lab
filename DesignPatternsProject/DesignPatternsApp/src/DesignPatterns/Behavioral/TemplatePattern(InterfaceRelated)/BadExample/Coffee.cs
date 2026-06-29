using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.BadExample
{
    public class Coffee
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup");
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