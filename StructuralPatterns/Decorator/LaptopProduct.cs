namespace StructuralPatterns.Decorator
{
    internal class LaptopProduct : IProduct
    {
        public int GetProductCost()
        {
            return 3500;
        }

        public string GetProductName()
        {
            return "Laptop";
        }
    }
}
