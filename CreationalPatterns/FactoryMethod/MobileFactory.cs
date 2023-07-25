namespace CreationalPatterns.FactoryMethod
{
    internal class MobileFactory : AbstractProductFactory
    {
        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            return new Mobile("7 inch", "11");
        }
    }
}
