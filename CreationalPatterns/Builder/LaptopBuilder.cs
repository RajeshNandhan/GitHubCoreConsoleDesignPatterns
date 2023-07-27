namespace CreationalPatterns.Builder
{
    internal class LaptopBuilder : AbstractProductBuilder
    {
        private Product product = new Product();

        public override Product BuildProduct()
        {
            return product;
        }

        public override AbstractProductBuilder SetMonitorSize()
        {
            product.MonitorSize = "15 inch";
            return this;
        }

        public override AbstractProductBuilder SetNumberOfKeys()
        {
            product.NumberOfKeys = "104";
            return this;
        }

        public override AbstractProductBuilder SetProductName()
        {
            product.ProductName = "Laptop";
            return this;
        }
    }
}
