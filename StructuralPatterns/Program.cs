using StructuralPatterns.Adapter;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
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
            ProxyClientTest();
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
        
    }
}
