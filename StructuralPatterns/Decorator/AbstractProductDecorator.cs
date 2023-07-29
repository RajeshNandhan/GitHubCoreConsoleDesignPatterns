namespace StructuralPatterns.Decorator
{
    /// <summary>
    /// Has a Product and Is a Product
    /// </summary>
    internal class AbstractProductDecorator : IProduct
    {
        protected IProduct product;

        public AbstractProductDecorator(IProduct product)
        {
            this.product = product;
        }

        public virtual int GetProductCost()
        {
            return product.GetProductCost();
        }

        public virtual string GetProductName()
        {
            return product.GetProductName();
        }
    }
}