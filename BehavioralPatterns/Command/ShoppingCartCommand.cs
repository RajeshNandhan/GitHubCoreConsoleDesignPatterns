namespace BehavioralPatterns.Command
{
    internal class ShoppingCartCommand : ICommand, ICommandCanExecute
    {
        private IShoppingCartRepository shoppingCartRepository;
        private string product;
        private int quantity;

        public ShoppingCartCommand(IShoppingCartRepository shoppingCartRepository,
            string product, int quantity)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.product = product;
            this.quantity = quantity;
        }

        public bool CanExecute()
        {
            return shoppingCartRepository != null;
        }

        public void Execute()
        {
            if (CanExecute())
                shoppingCartRepository.AddItemToShoppingCart(product, quantity);
        }

        public void UnExecute()
        {
            if (CanExecute())
                shoppingCartRepository.RemoveItemFromShoppingCart(product, quantity);
        }
    }
}
