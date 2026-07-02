using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.ChainOfResponsibilityPattern.GoodSolution
{
    public class Authenticator : Handler
    {
        public override bool CanHandle(HttpRequest request)
        {
            var username = request.ValidateUsername;
            var password = request.ValidatePassword;
   
            return !(username == "admin" && password == "password");
 
        }
    }
}