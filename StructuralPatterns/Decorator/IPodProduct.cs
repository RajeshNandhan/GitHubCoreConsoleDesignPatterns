namespace StructuralPatterns.Decorator
{
    internal class IPodProduct : IProduct
    {
        public int GetProductCost()
        {
            return 900;
        }

        public string GetProductName()
        {
            return "IPod";
        }
    }
}
