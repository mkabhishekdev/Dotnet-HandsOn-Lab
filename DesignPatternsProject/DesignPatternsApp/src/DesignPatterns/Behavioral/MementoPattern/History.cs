using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MementoPattern
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();

        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }   

        public void BackUp()
        {
            _states.Add(_editor.CreateState());
        }

        private void Undo()
        {
            if(_states.Count == 0)
            {
                Console.WriteLine("No states to restore.");
                return;
            }
            if (_states.Count > 0)
            {
                var lastState = _states.Last();
                _editor.RestoreState(lastState);
                _states.RemoveAt(_states.Count - 1);
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("History of states:");
            foreach (var state in _states)
            {
                Console.WriteLine($"Title: {state.GetTitle()}, {state.GetName},Content: {state.GetContent()}, Created At: {state.GetStateCreatedAt()}");
            }
        }
    }
} 