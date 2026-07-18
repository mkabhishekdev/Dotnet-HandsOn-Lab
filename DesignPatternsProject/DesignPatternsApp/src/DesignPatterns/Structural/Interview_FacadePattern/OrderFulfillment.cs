using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FacadePattern
{
    public class OrderFulfillment
    {
        private Inventory _inventory;

        public OrderFulfillment(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Fulfill(string name, string address, string[] items)
        {
            foreach (var item in items)
            {
                if (_inventory.CheckInventory(item))
                {
                    _inventory.ReduceInventory(item, 1);
                }
                else
                {
                    Console.WriteLine($"Item {item} is out of stock.");
                }
            }

            Console.WriteLine($"Order for {name} at {address} has been fulfilled.");
        }
    }
}