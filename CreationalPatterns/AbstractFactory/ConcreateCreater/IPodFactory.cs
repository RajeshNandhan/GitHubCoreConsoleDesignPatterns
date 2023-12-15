namespace CreationalPatterns.AbstractFactory
{
    internal class IPodFactory : AbstractProductFactory
    {
        public override KeyboardAbstractProduct Create_KeyboardAbstractProduct()
        {
            return new IPodKeyboard("4");
        }

        public override MonitorAbstractProduct Create_MonitorAbstractProduct()
        {
           return new IPodMonitor("2 inch");
        }
    }
}
