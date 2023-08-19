namespace BehavioralPatterns.Command
{
    internal class ProductInventoryCommand : ICommand, ICommandCanExecute
    {
        private IProductInventoryRepository productInventoryRepository;
        private string product;
        private int quantity;

        public ProductInventoryCommand(IProductInventoryRepository productInventoryRepository,
            string product, int quantity)
        {
            this.productInventoryRepository = productInventoryRepository;
            this.product = product;
            this.quantity = quantity;
        }

        public bool CanExecute()
        {
            return productInventoryRepository != null;
        }

        public void Execute()
        {
            if (CanExecute())
                productInventoryRepository.RemoveProductFromInventory(product, quantity);
        }

        public void UnExecute()
        {
            if (CanExecute())
                productInventoryRepository.AddProductToInventory(product, quantity);
        }
    }
}
