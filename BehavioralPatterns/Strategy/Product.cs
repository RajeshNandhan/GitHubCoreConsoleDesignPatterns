namespace BehavioralPatterns.Strategy
{
    internal class Product
    {
        private readonly IMonitorStrategy monitorStrategy;
        private readonly IMouseStrategy mouseStrategy;
        private readonly IKeyboardStrategy keyboardStrategy;
        private readonly ICameraStrategy cameraStrategy;
        private readonly IProductTypeStrategy productTypeStrategy;

        public Product(
            IMonitorStrategy monitorStrategy,
            IMouseStrategy mouseStrategy,
            IKeyboardStrategy keyboardStrategy,
            ICameraStrategy cameraStrategy,
            IProductTypeStrategy productTypeStrategy)
        {
            this.monitorStrategy = monitorStrategy;
            this.mouseStrategy = mouseStrategy;
            this.keyboardStrategy = keyboardStrategy;
            this.cameraStrategy = cameraStrategy;
            this.productTypeStrategy = productTypeStrategy;
        }

        public string GetMonitorInformation()
        {
            return monitorStrategy.GetMonitorType();
        }

        public string GetMouseInformation()
        {
            return mouseStrategy.GetMouseType();
        }

        public string GetKeyboardInformation()
        {
            return keyboardStrategy.GetNumberOfKeys();
        }

        public string GetCameraInformation()
        {
            return cameraStrategy.GetCamera();
        }

        public string GetProductType()
        {
            return productTypeStrategy.GetProductType();
        }
        public string ToProductString()
        {
            return $"\n {GetProductType()}\n, {GetMonitorInformation()}\n, {GetMouseInformation()}\n, {GetKeyboardInformation()}\n, {GetCameraInformation()}\n";
        }
    }
}
