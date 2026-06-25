using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.InterfaceSegregationPrinciple
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }

        double IShape2D.Area()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Area of Circle: {area}");
            return area;
        }
    }
}