namespace StructuralPatterns.Decorator
{
    internal class KeyboardAccessoryProductDecorator : AbstractProductDecorator
    {
        public KeyboardAccessoryProductDecorator(IProduct product) : base(product)
        {
        }

        public string GetKeyBoardName()
        {
            return "KeyBoard";
        }

        public int GetKeyCost()
        {
            return 250;
        }

        /* --------------------------------------*/
        public override int GetProductCost()
        {
            return base.GetProductCost() + GetKeyCost();
        }

        public override string GetProductName()
        {
            return base.GetProductName() + $" has {GetKeyBoardName()}, ";
        }
    }
}
