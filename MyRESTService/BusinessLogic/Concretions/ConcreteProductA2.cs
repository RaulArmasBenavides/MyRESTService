using MyRESTService.BusinessLogic.AbstractFactory;

namespace MyRESTService.BusinessLogic.Concretions
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "ConcreteProductA2 result";
        }
    }
}