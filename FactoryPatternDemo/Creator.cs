using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();

            // Now, use the product.
            return $"Creator: ${product.Operation()}";
        }
    }
}
