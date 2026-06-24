using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.OopPrinciples.Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }

        //overriding the Start method of the base class Vehicle
        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }
    }
}