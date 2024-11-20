using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRESTService.BusinessLogic.Strategy.Interfaces
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
