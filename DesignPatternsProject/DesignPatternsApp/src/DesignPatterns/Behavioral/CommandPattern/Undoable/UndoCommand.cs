using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.Undoable
{
    public class UndoCommand : Command
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() == 0)
            {
                Console.WriteLine("No commands to undo.");
                return;
            }

            UndoableCommand command = _history.Pop();
            command.Unexecute(); 
        }
    }
}