using CreationalPatterns.AbstractFactory;
using CreationalPatterns.Builder;
using CreationalPatterns.FactoryMethod;
using CreationalPatterns.Prototype;
using CreationalPatterns.Singleton;

namespace CreationalPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethodTest();

            //AbstractFactoryTest();

            //BuilderTest();

            //SingletonTest();

            PrototypeClientTest();
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

        private static void SingletonTest()
        {
            SingletonClient.TestMethod();
        }

        private static void PrototypeClientTest()
        {
            PrototypeClient.TestMethod();
        }
    }
}
