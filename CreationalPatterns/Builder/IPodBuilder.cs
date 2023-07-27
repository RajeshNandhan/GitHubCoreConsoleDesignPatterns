namespace CreationalPatterns.Builder
{
    internal class IPodBuilder : AbstractProductBuilder
    {
        private Product product = new Product();

        public override Product BuildProduct()
        {
            return product;
        }

        public override AbstractProductBuilder SetMonitorSize()
        {
            product.MonitorSize = "2 inch";
            return this;
        }

        public override AbstractProductBuilder SetNumberOfKeys()
        {
            product.NumberOfKeys = "4";
            return this;
        }

        public override AbstractProductBuilder SetProductName()
        {
            product.ProductName = "IPod";
            return this;
        }
    }
}
