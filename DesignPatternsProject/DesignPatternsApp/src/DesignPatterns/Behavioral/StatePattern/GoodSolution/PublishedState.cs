using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StatePattern.GoodSolution
{
    public class PublishedState : State
    {
        private Document _document;

        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            return; // Already published, do nothing
        }
    }
}