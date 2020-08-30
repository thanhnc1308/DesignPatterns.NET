namespace AbstractFactoryPattern
{
    public abstract class ProductAbstractFactory
    {
        private static readonly ProductFactory1 PRODUCT_FACTORY_1 = new ProductFactory1();
        private static readonly ProductFactory2 PRODUCT_FACTORY_2 = new ProductFactory2();

        public static ProductAbstractFactory GetFactory(ProductType type)
        {
            ProductAbstractFactory factory = null;
            switch (type) {
                case ProductType.Type1:
                    factory = PRODUCT_FACTORY_1;
                    break;
                case ProductType.Type2:
                    factory = PRODUCT_FACTORY_2;
                    break;
            }
            return factory;
        }

        public abstract Product1 GetProduct1();

        public abstract Product2 GetProduct2();
    }
}