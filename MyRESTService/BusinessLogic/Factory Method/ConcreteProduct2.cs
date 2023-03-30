using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRESTService.BusinessLogic.Factory_Method
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}