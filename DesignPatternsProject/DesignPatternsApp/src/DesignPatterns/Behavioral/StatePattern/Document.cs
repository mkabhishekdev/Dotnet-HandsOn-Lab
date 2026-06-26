using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StatePattern
{
    public class Document
    {
        public DocumentStates State { get; set; }   
        public UserRoles Role { get; set; }

        public void Publish()
        {
            if (State == DocumentStates.Draft && Role == UserRoles.Editor)
            {
                State = DocumentStates.Moderation;
                Console.WriteLine("Document is now in moderation.");
            }
            else if (State == DocumentStates.Moderation && Role == UserRoles.Admin)
            {
                State = DocumentStates.Published;
                Console.WriteLine("Document is now published.");
            }
            else
            {
                Console.WriteLine("You do not have permission to publish this document.");
            }
        }
    }
}