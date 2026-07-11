using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern.Good
{
    public class CompressionDecorator : DataDecorator
    {
        public CompressionDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            Console.WriteLine("Compressing data before saving...");
            string compressedData = Compress(data);
            _data.Save(compressedData);
        }

        public string Compress(string data)
        {
            return data.Substring(0,9);
        }
    }
}