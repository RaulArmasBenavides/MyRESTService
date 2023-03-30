using MyRESTService.BusinessLogic.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRESTService.BusinessLogic.Concretions
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "ConcreteProductA1 result ";
        }
    }
}