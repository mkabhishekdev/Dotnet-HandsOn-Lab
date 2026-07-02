using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithFramework.UIFramework
{
    public class UIControls
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler handler)
        {
            _eventHandlers.Add(handler);
        }   

        public void NotifyEventHandlers()
        {
            foreach (var handler in _eventHandlers)
            {
                handler.Invoke();
            }
        }
    }
}