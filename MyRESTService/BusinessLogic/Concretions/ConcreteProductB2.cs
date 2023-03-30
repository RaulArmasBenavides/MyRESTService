using MyRESTService.BusinessLogic.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyRESTService.BusinessLogic.Concretions
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            return "AnotherUsefulFunctionB2";
        }

        public string UsefulFunctionB()
        {
            return "UsefulFunctionB 2! ";
        }
    }
}