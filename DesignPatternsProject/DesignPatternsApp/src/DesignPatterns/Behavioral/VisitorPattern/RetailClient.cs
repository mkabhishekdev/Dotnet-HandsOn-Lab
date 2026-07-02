using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.VisitorPattern
{
    public class RetailClient : Client
    {
        public RetailClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            Console.WriteLine($"Sending email to Retail Client: {_name} at {_email}");
        }
    }
}