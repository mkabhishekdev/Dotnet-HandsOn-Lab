using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern
{
    public class WebServer
    {
        public void HandleRequest(HttpRequest request)
        {
            var validator = new Validator();
            validator.Validate(request);

            var logger = new Logger();
            logger.Log(request);

            var authenticator = new Authenticator();
            if (authenticator.Authenticate(request))
            {
                Console.WriteLine("Authentication successful. Processing request...");
                // Process the request further
            }
            else
            {
                Console.WriteLine("Authentication failed. Request denied.");
                // Handle authentication failure
            }
        }
    }
} 