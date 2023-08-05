using System;

namespace StructuralPatterns.Proxy
{
    internal class ProxyClient
    {
        public static void ProxyClientTest()
        {
            //Product created at the constructer is costly call

            RealProductBussinessLayer productBussinessLayer = new RealProductBussinessLayer("15 inch", "104", "Laptop");

            Console.WriteLine(productBussinessLayer.GetProductName());
            Console.WriteLine(productBussinessLayer.GetNumberOfKeys());
            Console.WriteLine(productBussinessLayer.GetMonitorSize());
            Console.WriteLine("\n");
            //only bussiness broxy created here, no product created yet

            ProxyProductBussinessLayer proxyProductBussinessLayer = new ProxyProductBussinessLayer("15 inch", "104", "Laptop");

            Console.WriteLine(proxyProductBussinessLayer.GetProductName());
            Console.WriteLine(proxyProductBussinessLayer.GetNumberOfKeys());
            Console.WriteLine(proxyProductBussinessLayer.GetMonitorSize());

            Console.ReadKey();
        }

        public static void TestMethod()
        {
            ProxyClientTest();
        }
    }
}
