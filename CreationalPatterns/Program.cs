using CreationalPatterns.FactoryMethod;

namespace CreationalPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodTest();
        }

        private static void FactoryMethodTest()
        {
            FactoryMethodClient.TestMethod();
        }
    }
}
