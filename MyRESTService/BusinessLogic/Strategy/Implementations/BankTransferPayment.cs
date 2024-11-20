﻿using MyRESTService.BusinessLogic.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.BusinessLogic.Strategy.Implementations
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Pagando {amount:C} con tarjeta de crédito.");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Pagando {amount:C} con PayPal.");
        }
    }

    public class BankTransferPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Pagando {amount:C} con transferencia bancaria.");
        }
    }


    public class YapePayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Pagando {amount:C} with yape.");
        }
    }

}
