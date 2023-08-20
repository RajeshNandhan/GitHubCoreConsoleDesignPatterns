using System;

namespace BehavioralPatterns.TemplateMethod
{
    internal class TemplateMethodClient
    {
        public static void BuyProduct()
        {
            bool canContinue;
            string consoleKeyInfo;
            ShoppingCartRepository shoppingCartRepository = new ShoppingCartRepository();

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
                        Product product = new Product(userSelectedProduct, userSelectedQuantity);
                        shoppingCartRepository.Product = product;

                        if (canAddItem)
                            shoppingCartRepository.AddItemToShoppingCart();
                        else
                            shoppingCartRepository.RemoveItemInShoppingCart();
                    }
                }

            } while (canContinue);
        }

        public static void TestMethod()
        {
            BuyProduct();
        }
    }
}