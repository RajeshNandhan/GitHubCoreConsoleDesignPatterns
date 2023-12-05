using BehavioralPatterns.Command;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Observer;
using BehavioralPatterns.Observer2;
using BehavioralPatterns.State;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.TemplateMethod;

namespace BehavioralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StrategyClient.TestMethod();
            ////ObserverClient.TestMethod();
            //ObserverClient2.TestMethod();
            //CommandClient.TestMethod();
            //TemplateMethodClient.TestMethod();
            //IteratorClient.TestMethod();
            StateClient.TestMethod();
        }
    }
}
