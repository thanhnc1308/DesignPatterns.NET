using System;

namespace FactoryMethodPattern
{
    public class ProductFactory : IProductFactory
    {
        public Product makeProduct(string type)
        {
            switch (type) {
                case "type1":
                    return new Product1();
                case "type2":
                    return new Product2();
            }
            return null;
        }
    }
}