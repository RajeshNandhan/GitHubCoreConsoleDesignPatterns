namespace CreationalPatterns.AbstractFactory
{
    internal abstract class AbstractProductFactory
    {
        public abstract KeyboardAbstractProduct Create_KeyboardAbstractProduct();

        public abstract MonitorAbstractProduct Create_MonitorAbstractProduct();
    }
}
