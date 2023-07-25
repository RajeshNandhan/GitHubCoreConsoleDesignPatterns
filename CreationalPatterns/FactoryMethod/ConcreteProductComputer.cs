using CreationalPatterns.FactoryMethod;

namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProductComputer
    /// </summary>
    internal class ConcreteProductComputer : AbstractProduct
    {
        public ConcreteProductComputer()
        {
            Monitor = "Computer Monitor";
        }
    }
}