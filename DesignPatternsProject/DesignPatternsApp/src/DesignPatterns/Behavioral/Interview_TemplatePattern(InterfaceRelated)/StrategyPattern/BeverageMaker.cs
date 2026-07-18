using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.TemplatePattern.GoodExample
{
    public class BeverageMaker
    {
        private Beverage _beverage;

        public BeverageMaker(Beverage beverage)
        {
            _beverage = beverage;
        }

        public void SetBeverage(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public void MakeBeverage()
        {
            // common operations
            BoilWater();
            PourWaterIntoCup();

             // unique operations
            _beverage.Prepare();  // polymorphism 
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            Console.WriteLine("Pouring water into cup");
        }
    }
}