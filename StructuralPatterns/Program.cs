using StructuralPatterns.Adapter;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using StructuralPatterns.Flyweight;
using StructuralPatterns.Proxy;

namespace StructuralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AdapterClientTest();
            //DecoratorClientTest();
            //FacadeClientTest();
            //ProxyClientTest();
            //CompositeClientTest();
            FlyweightClientTest();
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

        private static void ProxyClientTest()
        {
            ProxyClient.TestMethod();
        }

        private static void CompositeClientTest()
        {
            CompositeClient.TestMethod();
        }

        private static void FlyweightClientTest()
        {
            FlyweightClient.TestMethod();
        }
    }
}
