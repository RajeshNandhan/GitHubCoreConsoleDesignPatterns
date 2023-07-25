namespace CreationalPatterns.FactoryMethod
{
    internal class ConcreteProductMobileCreator : AbstractProductCreator
    {
        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            return new ConcreteProductMobile();
        }
    }
}
