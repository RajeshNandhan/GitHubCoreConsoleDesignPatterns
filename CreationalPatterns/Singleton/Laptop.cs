namespace CreationalPatterns.Singleton
{
    /// <summary>
    /// ConcreteProductLaptop
    /// </summary>
    internal class Laptop : AbstractProduct
    {
        public Laptop()
        {
            MonitorSize = "15 inch";
            NumberOfKeys = "104";
            ProductName = "Laptop";
            ProductCreationDateTime = System.DateTime.Now;
        }
    }
}
