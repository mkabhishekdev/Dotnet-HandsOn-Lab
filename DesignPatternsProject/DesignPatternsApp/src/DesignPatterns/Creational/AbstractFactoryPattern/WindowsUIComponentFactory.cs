using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern.UIWindows;

namespace DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class WindowsUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new WindowsCheckbox();
        }
    }
}