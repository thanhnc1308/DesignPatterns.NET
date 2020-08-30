namespace AbstractFactoryPattern
{
    public class ProductFactory1 : ProductAbstractFactory
    {
        public override Product1 GetProduct1()
        {
            return new Product1Type1();
        }

        public override Product2 GetProduct2()
        {
            return new Product2Type1();
        }
    }
}