﻿namespace MyRESTService.BusinessLogic.Factory_Method
{
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}