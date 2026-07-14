using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern.UIMac;
using DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern.UIWindows;

namespace DesignPatternsApp.src.DesignPatterns.Creational.AbstractFactoryPattern
{
    public class UserSettingsForm
    {
        public void Render(IUIComponentFactory uIComponentFactory)
        {
            uIComponentFactory.CreateButton().Render();  // 'Polymorphism' in action: 
            // The actual button created depends on the factory passed (Windows or Mac)
            uIComponentFactory.CreateCheckBox().Render();
        }
    }
}