using System;
using FactoryMethodPattern;

class Program
{
    static void Main(string[] args)
    {
        IProductFactory factory = new ProductFactory();
        Product product = factory.makeProduct("type1");
        System.Console.WriteLine(product.getProductName());
    }
}