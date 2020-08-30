namespace AbstractFactoryPattern
{
    public class ProductFactory2 : ProductAbstractFactory
    {
        public override Product1 GetProduct1()
        {
            return new Product1Type2();
        }

        public override Product2 GetProduct2()
        {
            return new Product2Type2();
        }
    }
}