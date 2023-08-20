using System;
using System.Text;

namespace BehavioralPatterns.TemplateMethod
{
    internal class ShoppingCartRepository : ShoppingCartTemplete
    {
        protected override void DisplayShoppingCartAndProductInventoryDetailsToUser()
        {
            StringBuilder shoppingCartStringBuilder = new StringBuilder();

            foreach (var item in ShoppingCart)
            {
                shoppingCartStringBuilder.Append($"Shopping Cart Item = {item.Key}, Quantity ={item.Value}.\n");
            }

            Console.WriteLine(shoppingCartStringBuilder.ToString());

            StringBuilder productInventoryStringBuilder = new StringBuilder();

            foreach (var item in ProductInventory)
            {
                productInventoryStringBuilder.Append($"Product Inventory Item = {item.Key}, Quantity ={item.Value}.\n");
            }

            Console.WriteLine(productInventoryStringBuilder.ToString());
        }

        protected override bool IsProductAvailableInProductInventory()
        {
            var existingQuantity = ProductInventory[Product.Name];
            return existingQuantity > Product.Quantity;
        }

        protected override void UpdateItemOfShoppingCart()
        {
            if (ShoppingCart.ContainsKey(Product.Name))
            {
                var existingQuantity = ShoppingCart[Product.Name];

                existingQuantity += Product.Quantity;

                ShoppingCart[Product.Name] = existingQuantity;
            }
            else
            {
                ShoppingCart.Add(Product.Name, Product.Quantity);
            }
        }

        protected override void UpdateProductOfProductInventory()
        {
            var existingQuantity = ProductInventory[Product.Name];

            existingQuantity -= Product.Quantity;

            ProductInventory[Product.Name] = existingQuantity;
        }
    }
}
