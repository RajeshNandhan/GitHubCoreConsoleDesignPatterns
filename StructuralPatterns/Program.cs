using StructuralPatterns.Adapter;

namespace StructuralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdapterClientTest();
        }

        private static void AdapterClientTest()
        {
            AdapterClient.TestMethod();
        }
    }
}
