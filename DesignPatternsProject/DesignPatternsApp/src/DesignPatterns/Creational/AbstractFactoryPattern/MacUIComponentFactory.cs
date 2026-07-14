using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern.UIMac;

namespace DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class MacUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckBox()
        {
           return new MacCheckbox();    
        }
    }
}