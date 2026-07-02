using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithFramework.UIFramework;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithObserver.UIFramework
{
    public class TextBox : UIControls
    {
        private string _text = "";

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            NotifyEventHandlers();
        }
    }
}