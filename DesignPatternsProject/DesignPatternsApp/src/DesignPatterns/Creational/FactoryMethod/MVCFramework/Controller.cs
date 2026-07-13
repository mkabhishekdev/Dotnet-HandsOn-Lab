using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.FactoryMethod.MVCFramework
{
    public class Controller
    {
        public void Render(string fileName, Dictionary<string, object> data)
        {
            var ViewEngine = new BladeViewEngine();
            var html = ViewEngine.Render(fileName, data);
            Console.WriteLine(html);
        }
    }
}