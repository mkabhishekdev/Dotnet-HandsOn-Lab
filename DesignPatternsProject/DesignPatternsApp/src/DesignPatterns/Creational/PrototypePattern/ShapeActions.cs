using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.PrototypePattern
{
    public class ShapeActions
    {
        public Shape Duplicate(Shape shape)
        {
            Console.WriteLine("Duplicating shape...");
            return shape.Duplicate();
        }
    }
} 