namespace CreationalPatterns.AbstractFactory
{
    internal class IPodMonitor : MonitorAbstractProduct
    {
        public IPodMonitor(string monitorSize)
        {
            MonitorSize = monitorSize;
            ProductName = "IPod";
        }
    }
}
