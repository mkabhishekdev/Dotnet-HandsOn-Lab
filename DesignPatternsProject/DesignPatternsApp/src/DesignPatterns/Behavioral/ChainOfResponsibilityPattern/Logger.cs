using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine($"Logging request: Username={request.ValidateUsername}, Password={request.ValidatePassword}");
        }
    }
}