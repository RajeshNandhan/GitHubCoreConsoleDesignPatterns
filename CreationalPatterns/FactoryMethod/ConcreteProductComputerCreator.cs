namespace CreationalPatterns.FactoryMethod
{
    internal class ConcreteProductComputerCreator : AbstractProductCreator
    {
        public override AbstractProduct FactoryMethod_CreateProduct()
        {
            return new ConcreteProductComputer();
        }
    }
}
