using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.VisitorPattern.Good
{
    public class RetailClientGood : Client
    {
        public RetailClientGood(string name, string email) : base(name, email)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRetail(this);
        }
    }
}