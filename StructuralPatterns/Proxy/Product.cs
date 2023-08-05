namespace StructuralPatterns.Proxy
{
    internal class Product
    {
        public string MonitorSize
        {
            get; set;
        }

        public string NumberOfKeys
        {
            get; set;
        }

        public string ProductName
        {
            get; set;
        }

        public Product(string monitorSize, string numberOfKeys, string productName)
        {
            MonitorSize = monitorSize;
            NumberOfKeys = numberOfKeys;
            ProductName = productName;
        }
    }
}
