using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.SingleResponsibilityPrinciple
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}