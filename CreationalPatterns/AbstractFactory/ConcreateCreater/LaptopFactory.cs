namespace CreationalPatterns.AbstractFactory
{
    internal class LaptopFactory : AbstractProductFactory
    {
        public override KeyboardAbstractProduct Create_KeyboardAbstractProduct()
        {
            return new LaptopKeyboard("104");
        }

        public override MonitorAbstractProduct Create_MonitorAbstractProduct()
        {
            return new LaptopMonitor("15 inch");
        }
    }
}
