using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.OopPrinciples.Polymorphism
{
    public class Bike : Vehicle
    {
        public int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("Bike is starting...");
        }
    }
}