using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern.UIMac
{
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac checkbox.");
        }
    }
}