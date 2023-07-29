namespace StructuralPatterns.Decorator
{
    internal class DeviceCoverAccessoryProductDecorator : AbstractProductDecorator
    {
        public DeviceCoverAccessoryProductDecorator(IProduct product) : base(product)
        {
        }

        public string GetDeviceCoverName()
        {
            return "DeviceCover";
        }

        public int GetDeviceCoverCost()
        {
            return 70;
        }

        /* --------------------------------------*/
        public override int GetProductCost()
        {
            return base.GetProductCost() + GetDeviceCoverCost();
        }

        public override string GetProductName()
        {
            return base.GetProductName() + $" has {GetDeviceCoverName()},";
        }
    }
}