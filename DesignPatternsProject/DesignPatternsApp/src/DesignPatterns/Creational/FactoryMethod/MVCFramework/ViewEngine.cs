using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.FactoryMethod.MVCFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string,object> data);
    }
}