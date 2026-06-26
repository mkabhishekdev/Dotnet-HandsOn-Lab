using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StatePattern.GoodSolution
{
    public class DraftState : State
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            _document.state = new ModerationState(_document);
            
        }
    }
}