using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern
{
    public class CloudData
    {
        protected string _url;

        public CloudData(string url)
        {
            _url = url;
        }

        public virtual void Save(string data)
        {
            Console.WriteLine($"Saving data to cloud at {_url}: {data}");
        }

    }
}