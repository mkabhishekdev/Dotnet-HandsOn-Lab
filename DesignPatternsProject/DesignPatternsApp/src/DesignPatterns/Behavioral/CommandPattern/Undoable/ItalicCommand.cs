using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.Undoable
{
    public class ItalicCommand : UndoableCommand
    {
        private HtmlDocument _document;
        private string _previousContent = "";
        private History _history;

        public ItalicCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }   

        public void Execute()
        {
            _previousContent = _document.Content;
            _document.MakeItalic();
            _history.Push(this);
        }

        public void Unexecute()
        {
            _document.Content = _previousContent;
        }
    }
}