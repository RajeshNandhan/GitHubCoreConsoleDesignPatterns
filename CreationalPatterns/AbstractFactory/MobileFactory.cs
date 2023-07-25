namespace CreationalPatterns.AbstractFactory
{
    internal class MobileFactory : AbstractProductFactory
    {
        public override KeyboardAbstractProduct Create_KeyboardAbstractProduct()
        {
            return new MobileKeyboard("11");
        }

        public override MonitorAbstractProduct Create_MonitorAbstractProduct()
        {
            return new MobileMonitor("7 inch");
        }
    }
}
