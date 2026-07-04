using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Composite
{
    public class Microphone : Item
    {
        private float _price = 60.00f;

        public float GetPrice()
        {
            return _price;
        }
    }
}