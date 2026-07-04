using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Composite
{
    public class Mouse : Item
    {
        private float _price = 20.00f;
        public float GetPrice()
        {
            return _price;
        }
    }
}