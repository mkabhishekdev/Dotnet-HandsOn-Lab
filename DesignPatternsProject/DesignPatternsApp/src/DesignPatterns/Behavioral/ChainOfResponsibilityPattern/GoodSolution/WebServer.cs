using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern.GoodSolution
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void HandleRequest(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}