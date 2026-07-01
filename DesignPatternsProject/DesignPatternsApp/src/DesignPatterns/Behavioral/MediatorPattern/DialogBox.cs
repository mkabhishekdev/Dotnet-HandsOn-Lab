using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorPattern
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }

   
}