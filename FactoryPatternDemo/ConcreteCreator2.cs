using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
