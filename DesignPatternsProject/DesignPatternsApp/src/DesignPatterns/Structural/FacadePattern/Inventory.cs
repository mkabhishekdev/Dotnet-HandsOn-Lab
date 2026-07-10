using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FacadePattern
{
    public class Inventory
    {
        public bool CheckInventory(string itemId)
        {
            return true; // just to keep it simple
        }

        public void ReduceInventory(string itemId, int amount)
        {
            Console.WriteLine($"Reducing inventory for item {itemId} by {amount}");
        }
    }
} 