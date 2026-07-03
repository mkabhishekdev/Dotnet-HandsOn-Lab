using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.VisitorPattern.Good
{
    public interface IVisitor
    {
        void VisitRetail(RetailClientGood retailClient);
        void VisitLaw(LawClientGood lawClient);
        void VisitRestaurant(RestaurantClientGood restaurantClient);

    }
}