using StructuralPatterns.Adapter;
using StructuralPatterns.Decorator;

namespace StructuralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AdapterClientTest();
            DecoratorClientTest();
        }

        private static void AdapterClientTest()
        {
            AdapterClient.TestMethod();
        }

        private static void DecoratorClientTest()
        {
            DecoratorClient.TestMethod();
        }
    }
}
