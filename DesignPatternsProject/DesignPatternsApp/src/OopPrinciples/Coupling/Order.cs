using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService _notificationService;

        public Order(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            // Order placement logic
            Console.WriteLine("Order placed successfully.");

            // Send notification
            _notificationService.SendNotification("Your order has been placed.");
        }
    }
}