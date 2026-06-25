using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.OopPrinciples.Composition
{
    public class Car
    {
        private SkeletalVehicleBase skeletalVehicleBase = new SkeletalVehicleBase();
        private Engine engine = new Engine();
        private Wheels wheels = new Wheels();
        private Seats seats = new Seats();  

        public void StartCar()
        {
            skeletalVehicleBase.Support();
            engine.Start();
            wheels.Rotate();
            seats.Sit();
            Console.WriteLine("Car is ready to drive");
        }
    }
}