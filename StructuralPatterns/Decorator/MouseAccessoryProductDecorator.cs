namespace StructuralPatterns.Decorator
{
    internal class MouseAccessoryProductDecorator : AbstractProductDecorator
    {
        public MouseAccessoryProductDecorator(IProduct product) : base(product)
        {
        }

        public string GetMouseName()
        {
            return "Mouse";
        }

        public int GetMouseCost()
        {
            return 150;
        }

        /* --------------------------------------*/
        public override int GetProductCost()
        {
            return base.GetProductCost() + GetMouseCost();
        }

        public override string GetProductName()
        {
            return base.GetProductName() + $" has {GetMouseName()},";
        }
    }
}
