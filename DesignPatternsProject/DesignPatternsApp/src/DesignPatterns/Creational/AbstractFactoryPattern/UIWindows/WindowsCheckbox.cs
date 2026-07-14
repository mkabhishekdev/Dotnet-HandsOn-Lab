using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern.UIWindows
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows checkbox.");
        }
    }
}