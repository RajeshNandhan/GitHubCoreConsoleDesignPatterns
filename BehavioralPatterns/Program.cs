using BehavioralPatterns.Observer;
using BehavioralPatterns.Observer2;
using BehavioralPatterns.Strategy;

namespace BehavioralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StrategyClientTest();
            ObserverClientTest();
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
    }
}
