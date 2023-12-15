namespace CreationalPatterns.AbstractFactory
{
    internal class MobileMonitor : MonitorAbstractProduct
    {
        public MobileMonitor(string monitorSize)
        {
            MonitorSize = monitorSize;
            ProductName = "Mobile";
        }
    }
}
