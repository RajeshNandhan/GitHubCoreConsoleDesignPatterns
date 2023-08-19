namespace BehavioralPatterns.Command
{
    internal class OnlineShoppingInvoker
    {
        private readonly ICommand productInventoryCommand;
        private readonly ICommand shoppingCartCommand;

        public OnlineShoppingInvoker(ICommand productInventoryCommand, ICommand shoppingCartCommand)
        {
            this.productInventoryCommand = productInventoryCommand;
            this.shoppingCartCommand = shoppingCartCommand;
        }

        public void AddItemInvoker()
        {
            shoppingCartCommand.Execute();

            productInventoryCommand.Execute();
        }

        public void RemoveItemInvoker()
        {
            shoppingCartCommand.UnExecute();

            productInventoryCommand.UnExecute();
        }
    }
}
