using StructuralPatterns.Adapter;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;

namespace StructuralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AdapterClientTest();
            //DecoratorClientTest();
            FacadeClientTest();
        }

        private static void AdapterClientTest()
        {
            AdapterClient.TestMethod();
        }

        private static void DecoratorClientTest()
        {
            DecoratorClient.TestMethod();
        }

        private static void FacadeClientTest()
        {
            FacadeClient.TestMethod();
        }
    }
}
