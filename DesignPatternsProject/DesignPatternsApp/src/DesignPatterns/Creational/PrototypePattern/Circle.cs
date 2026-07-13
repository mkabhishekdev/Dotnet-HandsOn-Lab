using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.PrototypePattern
{
    public class Circle : Shape
    {
        public int Radius { get; set; } = 5;
        public void Draw()
        {
            Console.WriteLine($"Drawing a Circle with Radius: {Radius}");
        }

        public Shape Duplicate()
        {
            var newCircle = new Circle();
            newCircle.Radius = Radius; // copy the radius
            return newCircle;
        }
    }
}