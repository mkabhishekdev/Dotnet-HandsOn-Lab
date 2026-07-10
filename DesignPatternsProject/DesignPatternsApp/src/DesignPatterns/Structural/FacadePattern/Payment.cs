using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FacadePattern
{
    public class Payment
    {
        private readonly string _name;
        private readonly string _cardNumber;
        private readonly float _amount;

        public Payment(string name, string cardNumber, float amount)
        {
            _name = name;
            _cardNumber = cardNumber;
            _amount = amount;
        }
        
        public void Pay()
        {
            Console.WriteLine($"Processing payment of {_amount} for {_name} using card {_cardNumber}");
        }

    }
}