using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.Undoable
{
    public class History
    {
        private List<UndoableCommand> _commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            _commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            if (_commands.Count == 0)
                return null;

            var command = _commands.Last();
            _commands.RemoveAt(_commands.Count - 1);
            return command;
        }

        public int Size()
        {
            return _commands.Count; 
        }
    }
}