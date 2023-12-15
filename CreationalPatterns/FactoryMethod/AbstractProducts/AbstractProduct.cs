namespace CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// AbstractProduct
    /// </summary>
    internal abstract class AbstractProduct
    {
        /// <summary>
        /// Property Not so relevent for this patter test
        /// </summary>
        public string MonitorSize
        {
            get;
            set;
        }

        public string NumberOfKeys
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
            return $"Product Name - {ProductName}, Monitor Size - {MonitorSize}, Number Of Keys -{NumberOfKeys}";
        }
    }
}