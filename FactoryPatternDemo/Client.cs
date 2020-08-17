using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public class Client
    {
        public void Start()
        {
            Console.WriteLine("Application Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());
            Console.WriteLine("Application Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine(creator.SomeOperation());
        }
    }
}
