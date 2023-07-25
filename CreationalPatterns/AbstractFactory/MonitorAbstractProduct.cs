namespace CreationalPatterns.AbstractFactory
{
    internal abstract class MonitorAbstractProduct
    {
        public string MonitorSize
        {
            get;
            set;
        }

        public string ProductName
        {
            get;
            set;
        }


        public string ToProductString()
        {
            return $"Product Name - {ProductName}, Monitor Size - {MonitorSize}";
        }
    }
}
