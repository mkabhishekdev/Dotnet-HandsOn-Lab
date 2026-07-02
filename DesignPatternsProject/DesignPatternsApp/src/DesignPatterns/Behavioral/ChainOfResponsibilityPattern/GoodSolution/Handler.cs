using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern.GoodSolution
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            return handler;
        }   

        public void Handle(HttpRequest request)
        {
            if (CanHandle(request))
            {
                return;
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine("No handler available for the request.");
            }
        }

        public abstract bool CanHandle(HttpRequest request);
    }
}