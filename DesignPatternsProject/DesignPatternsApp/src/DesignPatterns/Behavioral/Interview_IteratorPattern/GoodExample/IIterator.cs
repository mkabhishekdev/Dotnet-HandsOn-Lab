using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.IteratorPattern.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}