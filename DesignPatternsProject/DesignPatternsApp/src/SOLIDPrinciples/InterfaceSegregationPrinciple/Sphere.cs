using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.InterfaceSegregationPrinciple
{
    public class Sphere : IShape3D
    {
        public double Radius { get; set; }

        public double Area()
        {
            double area = 4 * Math.PI * Radius * Radius;
            Console.WriteLine($"Surface Area of Sphere: {area}");
            return area;
        }

        public double Volume()
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
            Console.WriteLine($"Volume of Sphere: {volume}");
            return volume;
        }
    }
}