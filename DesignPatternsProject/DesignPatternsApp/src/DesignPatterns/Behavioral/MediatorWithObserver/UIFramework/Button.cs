using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorPattern;
using DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithFramework.UIFramework;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithObserver.UIFramework
{
    public class Button : UIControls
    {
        private bool _isEnabled = true;

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            _isEnabled = enabled;
            NotifyEventHandlers();
        }
    }
}