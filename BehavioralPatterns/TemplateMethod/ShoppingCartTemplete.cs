using System;
using System.Collections.Generic;

namespace BehavioralPatterns.TemplateMethod
{
    internal abstract class ShoppingCartTemplete
    {
        //shoppingCart and productInventory management is not part of templete method pattern
        private static Dictionary<string, int> shoppingCart;
        private static Dictionary<string, int> productInventory;

        static ShoppingCartTemplete()
        {
            shoppingCart = new Dictionary<string, int>();

            productInventory = new Dictionary<string, int>
            {
                { "Laptop", 100 },
                { "Mobile", 50 },
                { "IPod", 20 }
            };
        }

        public Dictionary<string, int> ShoppingCart
        {
            get { return shoppingCart; }
        }

        public Dictionary<string, int> ProductInventory
        {
            get { return productInventory; }
        }

        public Product Product
        {
            get;
            set;
        }

        public void AddItemToShoppingCart()
        {
            Console.WriteLine("Process : Checking Product Availablity In Product Inventory...");

            bool validTransaction = IsProductAvailableInProductInventory();

            if (validTransaction)
            {
                Console.WriteLine("Process : Updating Item state of Shopping Cart...");

                UpdateItemOfShoppingCart();

                Console.WriteLine("Process : Updating Product state Of Product Inventory...");

                UpdateProductOfProductInventory();
            }
            else
            {
                Console.WriteLine("Message : Product NOT Availablity In Product Inventory");
            }

            DisplayShoppingCartAndProductInventoryDetailsToUser();
        }

        public void RemoveItemInShoppingCart()
        {
            //Reduce product quantity for shopping cart and increase the same quantity back in inventry product
            Product.Quantity = -1 * Product.Quantity;
            AddItemToShoppingCart();
        }

        protected abstract bool IsProductAvailableInProductInventory();

        protected abstract void UpdateItemOfShoppingCart();

        protected abstract void UpdateProductOfProductInventory();

        protected abstract void DisplayShoppingCartAndProductInventoryDetailsToUser();
    }
}
