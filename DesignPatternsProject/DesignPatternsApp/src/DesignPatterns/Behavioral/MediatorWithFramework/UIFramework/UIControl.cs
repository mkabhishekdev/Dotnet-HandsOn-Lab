using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.MediatorWithFramework.UIFramework
{
    public class UIControl
    {
        private List<EventHandler> _eventHandlers = new List<EventHandler>();

        public void AddEventHandler(EventHandler handler)
        {
            _eventHandlers.Add(handler);
        }   
    }
}