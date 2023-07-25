namespace CreationalPatterns.AbstractFactory
{
    internal class IPodKeyboard : KeyboardAbstractProduct
    {
        public IPodKeyboard(string numberOfKeys)
        {
            NumberOfKeys = numberOfKeys;
        }
    }
}
