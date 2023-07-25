namespace CreationalPatterns.AbstractFactory
{
    internal class MobileKeyboard : KeyboardAbstractProduct
    {
        public MobileKeyboard(string numberOfKeys)
        {
            NumberOfKeys = numberOfKeys;
        }
    }
}
