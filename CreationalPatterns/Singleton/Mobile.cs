namespace CreationalPatterns.Singleton
{
    /// <summary>
    /// ConcreteProductMobile
    /// </summary>
    internal class Mobile : AbstractProduct
    {
        public Mobile()
        {
            MonitorSize = "7 inch";
            NumberOfKeys = "11";
            ProductName = "Laptop";
            ProductCreationDateTime = System.DateTime.Now;
        }
    }
}