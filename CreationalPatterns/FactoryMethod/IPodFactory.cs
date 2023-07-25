namespace CreationalPatterns.FactoryMethod
{
    internal class IPodFactory : AbstractProductFactory
    {
        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            return new IPod("2 inch", "4");
        }
    }
}
