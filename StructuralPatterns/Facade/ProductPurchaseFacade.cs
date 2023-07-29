namespace StructuralPatterns.Facade
{
    internal class ProductPurchaseFacade
    {
        private Computer computer { get; set; }

        private IPod iPod { get; set; }

        private Laptop laptop { get; set; }

        private Mobile mobile { get; set; }

        public ProductPurchaseFacade()
        {
            computer = new Computer();
            laptop = new Laptop();
            mobile = new Mobile();
            iPod = new IPod();
        }

        public string GetProducts()
        {
            return $"{iPod.GetProductName()} ,{laptop.GetProductName()}, {mobile.GetProductName()}, {computer.GetProductName()}\n";
        }

        public int GetProductActualCost()
        {
            return iPod.GetProductCost() + mobile.GetProductCost() + laptop.GetProductCost() + computer.GetProductCost();
        }

        public int GetProductCoverCost()
        {
            return iPod.GetDeviceCoverCost() + mobile.GetDeviceCoverCost() + laptop.GetDeviceCoverCost() + computer.GetDeviceCoverCost();
        }

        public int GetProductKeyBoardCost()
        {
            return computer.GetKeyBoardCost();
        }

        public int GetProductMouseCost()
        {
            return laptop.GetMouseCost() + computer.GetMouseCost();
        }
    }
}
