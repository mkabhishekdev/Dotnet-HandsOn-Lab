using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.OpenClosedPrinciple
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}