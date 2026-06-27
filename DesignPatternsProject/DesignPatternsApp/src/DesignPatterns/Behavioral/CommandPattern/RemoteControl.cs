using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern
{
    // Invoker
    public class RemoteControl
    {
        public Light _light;

        public RemoteControl(Light light)
        {
            _light = light;
        }

        public void PressButton(bool turnOn)
        {
            if (turnOn)
            {
                _light.TurnOn();
            }
            else
            {
                _light.TurnOff();
            }
        }
    }
}