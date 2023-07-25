namespace CreationalPatterns.FactoryMethod
{
    internal class ConcreteProductLaptopCreator : AbstractProductCreator
    {
        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            return new ConcreteProductLaptop();
        }
    }
}
