namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProductLaptop
    /// </summary>
    internal class Laptop : AbstractProduct
    {
        public Laptop(string monitorSize, string numberOfKeys)
        {
            MonitorSize = monitorSize;
            NumberOfKeys = numberOfKeys;
            ProductName = "Laptop";
        }
    }
}
