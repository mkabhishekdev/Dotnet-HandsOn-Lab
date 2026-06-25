using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.InterfaceSegregationPrinciple
{
    public interface IShape3D
    {
        double Area();

        double Volume();
    }
}