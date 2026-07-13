using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.PrototypePattern
{
    public interface Shape
    {
        public void Draw();
        Shape Duplicate();
    }
}