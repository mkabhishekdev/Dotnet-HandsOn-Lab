using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Composite
{
    public class Box : Item
    {
        private List<Item> _items = new List<Item>();   

        public void AddItem(Item item)
        {
            _items.Add(item);
        }   

        public float GetPrice()
        {
            float totalPrice = 0.0f;
            foreach (var item in _items)
            {
                totalPrice += item.GetPrice();
            }
            return totalPrice;
        }
    }
}