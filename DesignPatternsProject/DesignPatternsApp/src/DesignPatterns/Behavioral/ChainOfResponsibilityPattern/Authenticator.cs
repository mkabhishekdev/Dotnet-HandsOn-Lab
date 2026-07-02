using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var username = request.ValidateUsername;
            var password = request.ValidatePassword;

            // Perform authentication logic here (e.g., check against a database)
            // For demonstration purposes, let's assume a simple check
            if (username == "admin" && password == "password")
            {
                return true; // Authentication successful
            }

            return false; // Authentication failed
        }
    }
}