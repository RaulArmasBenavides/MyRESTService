using MyRESTService.BusinessLogic.AbstractFactory;

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