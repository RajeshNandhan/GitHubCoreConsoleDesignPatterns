namespace CreationalPatterns.Singleton
{
    /// <summary>
    /// ConcreteProductComputer
    /// </summary>
    internal class IPod : AbstractProduct
    {
        public IPod()
        {
            MonitorSize = "2 inch";
            NumberOfKeys = "4";
            ProductName = "IPod";
            ProductCreationDateTime = System.DateTime.Now;
        }
    }
}