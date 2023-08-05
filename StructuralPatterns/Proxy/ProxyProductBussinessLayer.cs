
namespace StructuralPatterns.Proxy
{
    internal class ProxyProductBussinessLayer : IProductBussinessLayer
    {
        private RealProductBussinessLayer realProductBussinessLayer;

        public ProxyProductBussinessLayer(string monitorSize, string numberOfKeys, string productName)
        {
            this.monitorSize = monitorSize;
            this.numberOfKeys = numberOfKeys;
            this.productName = productName;
        }

        private string monitorSize { get; }
        private string numberOfKeys { get; }
        private string productName { get; }

        public string GetMonitorSize()
        {// Use 'lazy initialization'
            if (realProductBussinessLayer == null)
            {
                realProductBussinessLayer = new RealProductBussinessLayer(monitorSize, numberOfKeys, productName);
            }

            return realProductBussinessLayer.GetMonitorSize();
        }

        public string GetNumberOfKeys()
        {// Use 'lazy initialization'
            if (realProductBussinessLayer == null)
            {
                realProductBussinessLayer = new RealProductBussinessLayer(monitorSize, numberOfKeys, productName);
            }

            return realProductBussinessLayer.GetNumberOfKeys();
        }

        public string GetProductName()
        {// Use 'lazy initialization'
            if (realProductBussinessLayer == null)
            {
                realProductBussinessLayer = new RealProductBussinessLayer(monitorSize, numberOfKeys, productName);
            }

            return realProductBussinessLayer.GetProductName();
        }
    }
}
