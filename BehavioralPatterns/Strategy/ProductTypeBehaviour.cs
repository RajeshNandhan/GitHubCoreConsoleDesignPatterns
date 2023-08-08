namespace BehavioralPatterns.Strategy
{
    internal class ProductTypeBehaviour : IProductTypeStrategy
    {
        private readonly string productType;

        public ProductTypeBehaviour(string productType)
        {
            this.productType = productType;
        }

        public string GetProductType()
        {
            return "Product Type = " + productType;
        }
    }
}
