using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.VisitorPattern
{
    public class LawClient : Client
    {
        public LawClient(string name, string email) : base(name, email)
        {
            
        }

        public override void SendEmail()
        {
            Console.WriteLine($"Sending email to Law Client: {_name} at {_email}");
        }
    }
}