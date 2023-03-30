using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRESTService.BusinessLogic.Factory_Method
{
     class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}