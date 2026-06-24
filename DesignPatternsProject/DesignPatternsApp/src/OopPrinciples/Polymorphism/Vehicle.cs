using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.OopPrinciples.Polymorphism
{
    /*
    Poly = many
    Morph = forms
    Polymorphism is the ability of an object to take on many forms. In C#, 
    polymorphism is achieved through method overriding and method overloading. 
    It allows you to define a single interface
    */
    /*
    Polymorphism implementation example:
    List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4, NumberOfWheels = 4 });
vehicles.Add(new Bike { Brand = "Honda", Model = "CBR500R", Year = 2021, NumberOfWheels = 2 });

foreach (var vehicle in vehicles)
{
    Console.WriteLine($"Brand: {vehicle.Brand}, Model: {vehicle.Model}, Year: {vehicle.Year}");
    vehicle.Start();
    vehicle.Stop();
}
    */
    public class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

       // virtual methods can be overridden in derived classes, allowing for polymorphic behavior.
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }


    }
} 