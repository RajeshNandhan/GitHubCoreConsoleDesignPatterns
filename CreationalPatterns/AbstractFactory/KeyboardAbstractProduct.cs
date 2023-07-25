namespace CreationalPatterns.AbstractFactory
{
    internal abstract class KeyboardAbstractProduct
    {
        public string NumberOfKeys
        {
            get;
            set;
        }


        public string ToProductString()
        {
            return $"Number Of Keys -{NumberOfKeys}";
        }
    }
}
