using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ObserverPattern_PubSubPattern
{
    public class BarChart : Observer
    {
        private DataSource _dataSource;
        
        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Rendering bar chart with new values");
        }
    }
}