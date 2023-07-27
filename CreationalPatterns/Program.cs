using CreationalPatterns.AbstractFactory;
using CreationalPatterns.Builder;
using CreationalPatterns.FactoryMethod;

namespace CreationalPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethodTest();

            //AbstractFactoryTest();

            BuilderTest();
        }

        private static void FactoryMethodTest()
        {
            FactoryMethodClient.TestMethod();
        }

        private static void AbstractFactoryTest()
        {
            AbstractFactoryClient.TestMethod();
        }

        private static void BuilderTest()
        {
            BuilderClient.TestMethod();
        }
    }
}
