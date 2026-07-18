using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.SingletonPattern
{
    public class Test
    {
        public static void Run()  // if you make the method static, you can call it without creating an instance
        //  of the class
        {
            var settings = AppSettings.GetInstance(); // notice how you are not creating a new instance of AppSettings, 
            // but rather getting the existing instance
            Console.WriteLine(settings.GetSetting("app_name")); 
        }
    }
}