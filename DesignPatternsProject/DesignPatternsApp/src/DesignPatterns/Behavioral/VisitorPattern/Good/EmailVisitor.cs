using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.VisitorPattern.Good
{
    public class EmailVisitor : IVisitor
    {
        public void VisitLaw(LawClientGood lawClient)
        {
            Console.WriteLine($"Sending email to law client: {lawClient.GetEmail()}");
        }

        public void VisitRestaurant(RestaurantClientGood restaurantClient)
        {
            Console.WriteLine($"Sending email to restaurant client: {restaurantClient.GetEmail()}");
        }

        public void VisitRetail(RetailClientGood retailClient)
        {
            Console.WriteLine($"Sending email to retail client: {retailClient.GetEmail()}");
        }
    }
}