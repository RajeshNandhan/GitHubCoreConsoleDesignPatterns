using System.Collections.Generic;

namespace BehavioralPatterns.Command
{
    internal class OnlineShoppingInvoker2
    {
        private List<ICommand> commandsForExecute;
        private List<ICommand> commandsForUnExecute;

        public void ShoppingCartAndProductInventoryExecuteCommandsToQue(ICommand addProductInventoryCommand, ICommand addShoppingCartCommand)
        {
            if (commandsForExecute == null)
            {
                commandsForExecute = new List<ICommand>();
            }

            commandsForExecute.Add(addShoppingCartCommand);
            commandsForExecute.Add(addProductInventoryCommand);
        }

        public void ShoppingCartAndProductInventoryUnExecuteCommandsToQue(ICommand removeProductInventoryCommand, ICommand removeShoppingCartCommand)
        {
            if (commandsForUnExecute == null)
            {
                commandsForUnExecute = new List<ICommand>();
            }

            commandsForUnExecute.Add(removeShoppingCartCommand);
            commandsForUnExecute.Add(removeProductInventoryCommand);
        }

        public void PlaceOrderCommandInvoker()
        {
            foreach (var command in commandsForExecute)
            {
                command.Execute();
            }

            foreach (var command in commandsForUnExecute)
            {
                command.UnExecute();
            }
        }
    }
}
