using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.DependencyInversionPrinciple
{
    public class Car 
    {
        private IEngine _engine; // remember it is IEngine interface, not concrete implementation of Engine or ElectricEngine
        
        public Car(IEngine engine) // because of dependency inversion principle, 
        // we are depending on abstraction (IEngine) rather than concrete implementation (Engine or ElectricEngine)
        //so during runtime we can call like Car(new Engine()) or Car(new ElectricEngine())
        {
            _engine = engine;
        }

        public void StartCar()
        {
            _engine.Start();
            Console.WriteLine("Car started.");
        }   


    }
}