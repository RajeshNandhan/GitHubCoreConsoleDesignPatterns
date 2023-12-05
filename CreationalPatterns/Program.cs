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
            //FactoryMethodClient.TestMethod();
            //AbstractFactoryClient.TestMethod();
            //BuilderClient.TestMethod();
            //SingletonClient.TestMethod();
            PrototypeClient.TestMethod();
        }
    }
}
