namespace CreationalPatterns.AbstractFactory
{
    internal class LaptopMonitor : MonitorAbstractProduct
    {
        public LaptopMonitor(string monitorSize)
        {
            MonitorSize = monitorSize;
            ProductName = "Laptop";
        }
    }
}
