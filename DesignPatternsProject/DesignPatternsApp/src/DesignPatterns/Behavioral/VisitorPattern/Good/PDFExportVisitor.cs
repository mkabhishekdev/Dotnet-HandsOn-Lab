using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.VisitorPattern.Good
{
    public class PDFExportVisitor : IVisitor
    {
        public void VisitLaw(LawClientGood lawClient)
        {
            Console.WriteLine($"Exporting law client {lawClient.GetEmail()} to PDF");
        }

        public void VisitRestaurant(RestaurantClientGood restaurantClient)
        {
            Console.WriteLine($"Exporting restaurant client {restaurantClient.GetEmail()} to PDF");
        }

        public void VisitRetail(RetailClientGood retailClient)
        {
            Console.WriteLine($"Exporting retail client {retailClient.GetEmail()} to PDF");
        }
    }
}