using BehavioralPatterns.Command;
using BehavioralPatterns.Observer;
using BehavioralPatterns.Observer2;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.TemplateMethod;

namespace BehavioralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StrategyClientTest();
            //ObserverClientTest();
            //CommandClientTest();
            TemplateMethodClientTest();
        }

        private static void StrategyClientTest()
        {
            StrategyClient.TestMethod();
        }

        private static void ObserverClientTest()
        {
            //ObserverClient.TestMethod();
            ObserverClient2.TestMethod();
        }

        private static void CommandClientTest()
        {
            CommandClient.TestMethod();
        }
        private static void TemplateMethodClientTest()
        {
            TemplateMethodClient.TestMethod();
        }
        
    }
}
