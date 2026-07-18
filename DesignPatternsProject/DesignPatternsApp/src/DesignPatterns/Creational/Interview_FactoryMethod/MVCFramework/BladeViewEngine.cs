using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.FactoryMethod.MVCFramework
{
    public class BladeViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data)
        {
            Console.WriteLine("Rendering view using BladeViewEngine");
            return "view rendered from " + fileName + " by blade" + "\n" +
            data.ToList().Aggregate("", (acc, kv) => acc + $"{kv.Key}: {kv.Value}\n");
        }
    }
}