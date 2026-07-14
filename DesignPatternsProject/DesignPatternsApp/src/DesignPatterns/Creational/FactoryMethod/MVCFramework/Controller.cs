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
            var viewEngine = createViewEngine();
            var html = viewEngine.Render(fileName, data);
            Console.WriteLine(html);
        }

        protected virtual ViewEngine createViewEngine()
        {
            return new BladeViewEngine();
        }
    }
}