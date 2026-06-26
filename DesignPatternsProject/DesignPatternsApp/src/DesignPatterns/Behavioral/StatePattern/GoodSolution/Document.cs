using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StatePattern.GoodSolution
{
    public class Document
    {
        public State state { get; set; } // the State here is an interface not an concrete class
        // so we can assign any state to it 
        // (DraftState, ModerationState, PublishedState)(this is the key point of the State pattern,
        //  we can change the state of the object at runtime)
        
        public UserRoles currentUserRole { get; set; }  

        public Document(UserRoles userRole)
        {
            currentUserRole = userRole;
            state = new DraftState(this);
        }

        public void Publish()
        {
            state.Publish();
        }
    }
}