namespace CreationalPatterns.FactoryMethod
{
    internal class LaptopFactory : AbstractProductFactory
    {
        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            return new Laptop("15 inch", "104");
        }
    }
}
