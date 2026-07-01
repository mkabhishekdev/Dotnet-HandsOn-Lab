using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ObserverPattern_PubSubPattern
{
    public class Sheet2 : Observer
    {
        private int _total;
        private DataSource _dataSource;

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public int GetTotal()
        {
            return _total;
        }

        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }

        public int CalculateTotal(List<int> values)
        {
            var sum = 0;

            foreach (var value in values)
            {
                sum += value;
            }

            Console.WriteLine($"Sheet2: Calculated total: {sum}");
            return sum;
        }
      
    }
}