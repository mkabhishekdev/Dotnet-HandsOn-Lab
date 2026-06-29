using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.Undoable
{
    public interface UndoableCommand : Command
    {
        void Unexecute();   
    }
}