namespace CreationalPatterns.AbstractFactory
{
    internal class LaptopKeyboard : KeyboardAbstractProduct
    {
        public LaptopKeyboard(string numberOfKeys)
        {
            NumberOfKeys = numberOfKeys;
        }
    }
}
