using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Creational.FactoryMethod.MVCFramework;

namespace DesignPatternsApp.src.DesignPatterns.Creational.FactoryMethod
{
    public class OrdersController : Controller
    {
        public void ListOrders()
        {
            // simulate fetching orders from database
            var orders = new Dictionary<string, object>()
            {
                {"shoes","Rs 1000"},
                {"shirts","Rs 500"},
                {"pants","Rs 700"}
            };

            Render("orders.blade.php", orders);
            
        }

        public void GetOrder(int id)
        {
            // simulate fetching order from database
            var order = new Dictionary<string, object>()
            {
                {"shoes", "Rs 1000"}
            };

            Render("order.php", order);
        }
    }
}