using System;
using AbstractFactoryPattern;

class Program
{
    static void Main(string[] args)
    {
        var factory = ProductAbstractFactory.GetFactory(ProductType.Type1);
        var product1 = factory.GetProduct1();
        var product2 = factory.GetProduct2();
        System.Console.WriteLine(product1.GetName());
        System.Console.WriteLine(product2.GetName());
    }
}