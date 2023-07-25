using CreationalPatterns.FactoryMethod;

namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProductComputer
    /// </summary>
    internal class IPod : AbstractProduct
    {
        public IPod(string monitorSize, string numberOfKeys)
        {
            MonitorSize = monitorSize;
            NumberOfKeys = numberOfKeys;
            ProductName = "IPod";
        }
    }
}