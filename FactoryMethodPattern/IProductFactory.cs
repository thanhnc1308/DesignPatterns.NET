using System;

namespace FactoryMethodPattern
{
    public interface IProductFactory
    {
        Product makeProduct(string type);
    }
}