using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.FactoryMethod.MVCFramework
{
    public class TwigController : Controller
    {
        protected override ViewEngine createViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}