using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern.Good
{
    public class CloudData : IData
    {
        private string _url;

        public CloudData(string url)
        {
            _url = url;
        }

        public void Save(string data)
        {
            Console.WriteLine($"Saving data to cloud at {_url}: {data}");
        }
    }
}