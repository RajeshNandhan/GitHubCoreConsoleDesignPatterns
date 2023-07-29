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

        public int GetKeyBoardCost()
        {
            return 250;
        }

        /* --------------------------------------*/
        public override int GetProductCost()
        {
            return base.GetProductCost() + GetKeyBoardCost();
        }

        public override string GetProductName()
        {
            return base.GetProductName() + $" has {GetKeyBoardName()}, ";
        }
    }
}
