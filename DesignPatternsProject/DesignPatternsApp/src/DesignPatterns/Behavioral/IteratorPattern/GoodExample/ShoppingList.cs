using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.IteratorPattern.GoodExample
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
        
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator: IIterator<string>
        {
            private ShoppingList _shoppingList;
            private int _currentIndex;

            public ListIterator(ShoppingList shoppingList)
            {
                _shoppingList = shoppingList;
                _currentIndex = 0;
            }

            public void Next()
            {
                if (HasNext())
                {
                    _currentIndex++;
                }
            }

            public bool HasNext()
            {
                return _currentIndex < _shoppingList.GetList().Count;
            }

            public string Current()
            {
                if (!HasNext())
                {
                    throw new InvalidOperationException("No more items in the shopping list.");
                }

                return _shoppingList.GetList()[_currentIndex];
            }
        }
    }
}