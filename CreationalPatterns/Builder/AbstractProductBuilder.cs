namespace CreationalPatterns.Builder
{
    internal abstract class AbstractProductBuilder
    {
        public abstract AbstractProductBuilder SetMonitorSize();

        public abstract AbstractProductBuilder SetNumberOfKeys();

        public abstract AbstractProductBuilder SetProductName();

        public abstract Product BuildProduct();
    }
}
