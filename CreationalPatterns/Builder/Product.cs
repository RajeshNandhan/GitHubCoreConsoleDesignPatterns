namespace CreationalPatterns.Builder
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

        public string ToProductString()
        {
            return $"Product Name - {ProductName}, Monitor Size - {MonitorSize}, Number Of Keys -{NumberOfKeys}";
        }
    }
}
