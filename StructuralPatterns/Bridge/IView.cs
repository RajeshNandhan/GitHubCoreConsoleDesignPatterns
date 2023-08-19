namespace StructuralPatterns.Bridge
{
    abstract class IView
    {
        protected IProductAdapter productAdapter;

        protected IView(IProductAdapter productAdapter)
        {
            this.productAdapter = productAdapter;
        }

        public abstract void DisplayProductData();
    }
}