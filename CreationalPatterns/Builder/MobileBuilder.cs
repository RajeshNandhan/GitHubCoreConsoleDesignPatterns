namespace CreationalPatterns.Builder
{
    internal class MobileBuilder : AbstractProductBuilder
    {
        private Product product = new Product();

        public override Product BuildProduct()
        {
            return product;
        }

        public override AbstractProductBuilder SetMonitorSize()
        {
            product.MonitorSize = "7 inch";
            return this;
        }

        public override AbstractProductBuilder SetNumberOfKeys()
        {
            product.NumberOfKeys = "11";
            return this;
        }

        public override AbstractProductBuilder SetProductName()
        {
            product.ProductName = "Mobile";
            return this;
        }
    }
}
