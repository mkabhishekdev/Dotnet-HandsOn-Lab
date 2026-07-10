using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FacadePattern
{
    // Request object containing user submitted order details
    public class OrderRequest
    {
        public string Name { get; } = "Abhi";
        public string CardNumber { get; } = "1234-5678-9012-3456";
        public float Amount { get; } = 300.0f;
        public string Address { get; } = "123 Main St, City, Country";
        public string[] ItemIds { get; } = new string[] { "123", "423", "555" };

    }
}