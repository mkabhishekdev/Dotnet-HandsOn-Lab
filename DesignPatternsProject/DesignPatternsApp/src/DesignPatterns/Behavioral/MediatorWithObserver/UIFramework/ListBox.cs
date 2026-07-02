using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorPattern;
using DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithFramework.UIFramework;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithObserver.UIFramework
{
    public class ListBox : UIControls
    {
        private string _selection = "";

        public string GetSelection()
        {
            return _selection;
        }

        public void SetSelection(string selection)
        {
            _selection = selection;
            NotifyEventHandlers();
        }
    }
}