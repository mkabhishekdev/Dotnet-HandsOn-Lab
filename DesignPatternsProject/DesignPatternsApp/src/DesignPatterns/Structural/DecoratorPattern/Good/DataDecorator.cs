using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern.Good
{
    public abstract class DataDecorator : IData
    {
        protected IData _data;

        public DataDecorator(IData data)
        {
            _data = data;
        }

        public abstract void Save(string data);
    }
}