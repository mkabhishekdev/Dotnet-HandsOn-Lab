using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FacadePattern
{
    public class OrderService
    {
        public void Order(OrderRequest orderRequest)
        {
            // Create instances of the subsystems
            var inventory = new Inventory();
            var payment = new Payment(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
            var orderFulfillment = new OrderFulfillment(inventory);

            // Process the order
            payment.Pay();
            orderFulfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemIds);
        }
    }
}