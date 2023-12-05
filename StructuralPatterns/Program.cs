using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
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
            //AdapterClient.TestMethod();
            //DecoratorClient.TestMethod();
            //FacadeClient.TestMethod();
            //ProxyClient.TestMethod();
            //CompositeClient.TestMethod();
            //FlyweightClient.TestMethod();
            BridgeClient.TestMethod();
        }
    }
}
