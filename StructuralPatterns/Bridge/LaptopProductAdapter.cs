namespace StructuralPatterns.Bridge
{
    internal class LaptopProductAdapter : IProductAdapter
    {
        private readonly LaptopProduct laptopProduct;

        public LaptopProductAdapter(LaptopProduct laptopProduct)
        {
            this.laptopProduct = laptopProduct;
        }

        public string GetDescription()
        {
            return laptopProduct.GetLaptopConfiguration();
        }

        public string GetMoreInformation()
        {
            return laptopProduct.GetLaptopCost() + ", " + laptopProduct.GetLaptopAccessories();
        }

        public string GetTitle()
        {
            return laptopProduct.GetLaptopName();
        }
    }
}
