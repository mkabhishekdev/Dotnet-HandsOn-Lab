using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckBox();
    }
}