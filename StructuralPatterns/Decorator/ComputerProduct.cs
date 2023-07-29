namespace StructuralPatterns.Decorator
{
    internal class ComputerProduct : IProduct
    {
        public int GetProductCost()
        {
            return 2000;
        }

        public string GetProductName()
        {
            return "Computer";
        }
    }
}
