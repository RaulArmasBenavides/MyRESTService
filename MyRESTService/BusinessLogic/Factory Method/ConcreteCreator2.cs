﻿namespace MyRESTService.BusinessLogic.Factory_Method
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}