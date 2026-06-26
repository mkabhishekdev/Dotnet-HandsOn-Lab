using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StatePattern.GoodSolution
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if(_document.currentUserRole == UserRoles.Admin)
            {
                _document.state = new PublishedState(_document);
            }
        }
    }
}