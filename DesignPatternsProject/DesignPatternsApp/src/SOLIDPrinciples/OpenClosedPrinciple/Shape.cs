using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.OpenClosedPrinciple
{
    /*abstract class means we can create methods that
    essentially have no body */
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    
}