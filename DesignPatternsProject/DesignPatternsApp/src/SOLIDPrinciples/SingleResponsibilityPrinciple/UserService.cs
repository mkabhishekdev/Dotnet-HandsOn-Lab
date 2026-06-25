using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.SOLIDPrinciples.SingleResponsibilityPrinciple
{
    public class UserService
    {
        public void Register(User user)
        {
            // Registration logic here

            //send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our application!");
        }
  
    }
}