using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.Adapter
{
    public interface Color
    {
        void Apply(Video video);
    }
}