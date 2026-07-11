using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern
{
    public class CompressedData : CloudData
    {
        public CompressedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            string compressedData = Compress(data);
            base.Save(compressedData);
        }

        public string Compress(string data)
        {
            return data.Substring(0,9);
        }
    }
   
}