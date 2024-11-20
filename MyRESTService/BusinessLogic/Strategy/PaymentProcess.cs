using MyRESTService.BusinessLogic.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.BusinessLogic.Strategy
{
    public class PaymentProcess
    {
        IPaymentStrategy _paymentStrategy;
        
        public PaymentProcess(IPaymentStrategy paymentStrategy) {
            _paymentStrategy = paymentStrategy;
        }
        public void SetSrategy(IPaymentStrategy strategy)
        {

            _paymentStrategy = strategy;
        }
        public void ProcessPay(decimal amout)
        {
            _paymentStrategy.ProcessPayment(amout);
        }

    }
}
