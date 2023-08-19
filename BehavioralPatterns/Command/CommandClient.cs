using System;

namespace BehavioralPatterns.Command
{
    internal class CommandClient
    {
        public static void BuyProduct_OnlineShoppingInvoker()
        {
            bool canContinue;
            string consoleKeyInfo;

            //Section 1
            IShoppingCartRepository shoppingCartRepository = new ShoppingCartRepository();
            IProductInventoryRepository productInventoryRepository = new ProductInventoryRepository();

            do
            {
                Console.WriteLine("Add Item (I - IPod, L - Laptop, M - Mobile),  Remove Item (II - IPod,  LL - Laptop,  MM - Mobile)");
                Console.WriteLine("Press Any other key to exit.");

                consoleKeyInfo = Console.ReadLine();
                string userSelectedProductKey = consoleKeyInfo.ToString().ToLower();

                string userSelectedProduct = string.Empty;
                bool canAddItem = false;
                canContinue = true;

                switch (userSelectedProductKey)
                {
                    case "l":
                        userSelectedProduct = "Laptop";
                        canAddItem = true;
                        break;
                    case "m":
                        userSelectedProduct = "Mobile";
                        canAddItem = true;
                        break;
                    case "i":
                        userSelectedProduct = "IPod";
                        canAddItem = true;
                        break;
                    case "ll":
                        userSelectedProduct = "Laptop";
                        canAddItem = false;
                        break;
                    case "mm":
                        userSelectedProduct = "Mobile";
                        canAddItem = false;
                        break;
                    case "ii":
                        userSelectedProduct = "IPod";
                        canAddItem = false;
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine("Please enter Number of Items.");
                    consoleKeyInfo = Console.ReadLine();
                    string numberofItemsKeyed = consoleKeyInfo.ToString().ToLower();
                    int userSelectedQuantity = int.Parse(numberofItemsKeyed);

                    if (userSelectedQuantity > 0)
                    {
                        //Section 2
                        ICommand productInventoryCommand = new ProductInventoryCommand(
                          productInventoryRepository, userSelectedProduct, userSelectedQuantity);

                        ICommand shoppingCartCommand = new ShoppingCartCommand(
                            shoppingCartRepository, userSelectedProduct, userSelectedQuantity);

                        OnlineShoppingInvoker onlineShoppingInvoker = new OnlineShoppingInvoker(productInventoryCommand, shoppingCartCommand);

                        if (canAddItem)
                        {
                            onlineShoppingInvoker.AddItemInvoker();
                        }
                        else
                            onlineShoppingInvoker.RemoveItemInvoker();
                    }
                }

                //Section 3
                Console.WriteLine(shoppingCartRepository.GetItemsInShoppingCartToString());
                Console.WriteLine(productInventoryRepository.GetProductInventoryItemsAvailablesToString());

            } while (canContinue);
        }

        public static void BuyProduct_OnlineShoppingInvoker2()
        {
            bool canContinue;
            string consoleKeyInfo;
            //Section 1
            IShoppingCartRepository shoppingCartRepository = new ShoppingCartRepository();
            IProductInventoryRepository productInventoryRepository = new ProductInventoryRepository();

            //Section 2
            OnlineShoppingInvoker2 onlineShoppingInvoker = new OnlineShoppingInvoker2(); ;

            do
            {
                Console.WriteLine("Add Item (I - IPod, L - Laptop, M - Mobile),  Remove Item (II - IPod,  LL - Laptop,  MM - Mobile)");
                Console.WriteLine("Press Any other key to exit and ORDER PLACEMENT.");

                consoleKeyInfo = Console.ReadLine();
                string userSelectedProductKey = consoleKeyInfo.ToString().ToLower();

                string userSelectedProduct = string.Empty;
                bool canAddItem = false;
                canContinue = true;

                switch (userSelectedProductKey)
                {
                    case "l":
                        userSelectedProduct = "Laptop";
                        canAddItem = true;
                        break;
                    case "m":
                        userSelectedProduct = "Mobile";
                        canAddItem = true;
                        break;
                    case "i":
                        userSelectedProduct = "IPod";
                        canAddItem = true;
                        break;
                    case "ll":
                        userSelectedProduct = "Laptop";
                        canAddItem = false;
                        break;
                    case "mm":
                        userSelectedProduct = "Mobile";
                        canAddItem = false;
                        break;
                    case "ii":
                        userSelectedProduct = "IPod";
                        canAddItem = false;
                        break;
                    default:
                        canContinue = false;
                        break;
                }

                if (canContinue)
                {
                    Console.WriteLine("Please enter Number of Items.");
                    consoleKeyInfo = Console.ReadLine();
                    string numberofItemsKeyed = consoleKeyInfo.ToString().ToLower();
                    int userSelectedQuantity = int.Parse(numberofItemsKeyed);

                    //Section 3
                    if (userSelectedQuantity > 0)
                    {
                        ICommand productInventoryCommand = new ProductInventoryCommand(
                          productInventoryRepository, userSelectedProduct, userSelectedQuantity);

                        ICommand shoppingCartCommand = new ShoppingCartCommand(
                            shoppingCartRepository, userSelectedProduct, userSelectedQuantity);

                        if (canAddItem)
                        {
                            onlineShoppingInvoker.ShoppingCartAndProductInventoryExecuteCommandsToQue(productInventoryCommand, shoppingCartCommand);
                        }
                        else
                            onlineShoppingInvoker.ShoppingCartAndProductInventoryUnExecuteCommandsToQue(productInventoryCommand, shoppingCartCommand);
                    }
                }
            } while (canContinue);

            //Section 4
            onlineShoppingInvoker.PlaceOrderCommandInvoker();

            Console.WriteLine(shoppingCartRepository.GetItemsInShoppingCartToString());
            Console.WriteLine(productInventoryRepository.GetProductInventoryItemsAvailablesToString());


            Console.WriteLine("Thank you, Press any key again for exit!!!");

            Console.ReadKey();
        }

        public static void TestMethod()
        {
            //BuyProduct_OnlineShoppingInvoker();
            BuyProduct_OnlineShoppingInvoker2();
        }
    }
}
