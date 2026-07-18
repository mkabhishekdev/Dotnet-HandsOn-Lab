using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.IteratorPattern
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();

        public void AddItem(string item)
        {
            _list.Add(item);
        }

        public string Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The shopping list is empty.");
            }

            string item = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return item;
        }

        public List<string> GetList()
        {
            return _list;
        }   
    }
}