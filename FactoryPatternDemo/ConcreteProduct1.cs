using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "From " + this.GetType().Name;
        }
    }
}
