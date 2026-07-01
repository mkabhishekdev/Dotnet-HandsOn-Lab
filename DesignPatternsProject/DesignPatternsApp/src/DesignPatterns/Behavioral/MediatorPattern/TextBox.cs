using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorPattern
{
    public class TextBox : UIControl
    {
        private string _text = "";
       
        public TextBox(DialogBox owner) : base(owner)
        {
            _owner = owner;
        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
            _owner.Changed(this);
        }
    }
}