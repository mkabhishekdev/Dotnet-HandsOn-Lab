using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorPattern
{
    public class Button : UIControl
    {
        private bool _isEnabled = true;

        public Button(DialogBox owner) : base(owner)
        {

        }

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            _isEnabled = enabled;
            _owner.Changed(this);
        }
    }
}