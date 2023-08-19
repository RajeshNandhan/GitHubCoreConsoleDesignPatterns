using System;

namespace BehavioralPatterns.Command
{
    internal class CommandClient
    {
        public static void BuyProduct()
        {
            bool canContinue;
            string consoleKeyInfo;
            //Section 1
            IShoppingCartRepository shoppingCartRepository = new ShoppingCartRepository();
            IProductInventoryRepository productInventoryRepository = new ProductInventoryRepository();

            //Section 2
            ICommand productInventoryCommand = null;
            ICommand shoppingCartCommand = null;
            OnlineShoppingInvoker onlineShoppingInvoker = null;

            do
            {
                Console.WriteLine("Add Item (I - IPod, L - Laptop, M - Mobile),  Remove Item (II - IPod,  LL - Laptop,  MM - Mobile)");
                Console.WriteLine("Press Any other key to exit.");

                consoleKeyInfo = Console.ReadLine();
                string userSelectedProductKey = consoleKeyInfo.ToString().ToLower();

                string userSelectedProduct = string.Empty;
                bool canAddItem = false;
                int userSelectedQuantity = 0;
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
                    userSelectedQuantity = int.Parse(numberofItemsKeyed);

                    //Section 3
                    if (userSelectedQuantity > 0)
                    {
                        productInventoryCommand = new ProductInventoryCommand(
                          productInventoryRepository, userSelectedProduct, userSelectedQuantity);

                        shoppingCartCommand = new ShoppingCartCommand(
                            shoppingCartRepository, userSelectedProduct, userSelectedQuantity);

                        onlineShoppingInvoker = new OnlineShoppingInvoker(productInventoryCommand, shoppingCartCommand);

                        if (canAddItem)
                        {
                            onlineShoppingInvoker.AddItemInvoker();
                        }
                        else
                            onlineShoppingInvoker.RemoveItemInvoker();
                    }
                }

                //Section 4
                Console.WriteLine(shoppingCartRepository.GetItemsInShoppingCartToString());
                Console.WriteLine(productInventoryRepository.GetProductInventoryItemsAvailablesToString());

            } while (canContinue);
        }

        public static void TestMethod()
        {
            BuyProduct();
        }
    }
}
