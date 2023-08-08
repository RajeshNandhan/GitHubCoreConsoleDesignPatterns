using BehavioralPatterns.Strategy;

namespace BehavioralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StrategyClientTest();
        }

        private static void StrategyClientTest()
        {
            StrategyClient.TestMethod();
        }
    }
}
