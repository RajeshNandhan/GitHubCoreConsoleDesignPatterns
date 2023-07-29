namespace StructuralPatterns.Decorator
{
    internal class MobileProduct : IProduct
    {
        public int GetProductCost()
        {
            return 760;
        }

        public string GetProductName()
        {
            return "Mobile";
        }
    }
}
