using CreationalPatterns.AbstractFactory;
using CreationalPatterns.FactoryMethod;

namespace CreationalPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethodTest();

            AbstractFactoryTest();
        }

        private static void FactoryMethodTest()
        {
            FactoryMethodClient.TestMethod();
        }

        private static void AbstractFactoryTest()
        {
            AbstractFactoryClient.TestMethod();
        }
    }
}
