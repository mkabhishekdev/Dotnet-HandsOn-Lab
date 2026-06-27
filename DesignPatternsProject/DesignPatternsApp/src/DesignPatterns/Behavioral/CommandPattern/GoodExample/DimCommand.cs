using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.GoodExample
{
    public class DimCommand : ICommand
    {
        private Light _light;

        public DimCommand(Light light)
        {
            _light = light; 
        }

        public void Execute()
        {
            _light.Dim();
        }
    }
} 