namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// ConcreteProductMobile
    /// </summary>
    internal class Mobile : AbstractProduct
    {
        public Mobile(string monitorSize, string numberOfKeys)
        {
            MonitorSize = monitorSize;
            NumberOfKeys = numberOfKeys;
            ProductName = "Laptop";
        }
    }
}