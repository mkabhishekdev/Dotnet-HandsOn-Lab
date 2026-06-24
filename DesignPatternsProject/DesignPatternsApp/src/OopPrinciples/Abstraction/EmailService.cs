using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Abstraction
 
 - Abstraction is the process of hiding the implementation details and showing only the functionality to the user.
   It helps to reduce complexity and allows the programmer to focus on interactions at a higher level.
   In C#, abstraction can be achieved using abstract classes and interfaces.
 
 * Example:
 - Abstract Class: An abstract class can have both abstract methods (without implementation) and 
 concrete methods (with implementation).
 - Interface: An interface can only have method signatures without any implementation. 
   Classes that implement the interface must provide implementations for all its methods.
 
*/

namespace DesignPatternsApp.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating user...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server...");
        }
    }
}