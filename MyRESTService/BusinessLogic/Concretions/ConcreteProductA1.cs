using MyRESTService.BusinessLogic.AbstractFactory;

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