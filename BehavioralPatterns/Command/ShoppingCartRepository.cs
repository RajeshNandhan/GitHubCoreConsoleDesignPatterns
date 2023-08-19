using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Command
{
    internal class ShoppingCartRepository : IShoppingCartRepository
    {
        private Dictionary<string, int> shoppingCart = new Dictionary<string, int>();

        public ShoppingCartRepository()
        {
            shoppingCart = new Dictionary<string, int>();
        }

        public void AddItemToShoppingCart(string product, int quantity)
        {
            if (shoppingCart.ContainsKey(product))
            {
                var existingQuantity = shoppingCart[product];
                existingQuantity += quantity;
                shoppingCart[product] = existingQuantity;
            }
            else
            {
                shoppingCart.Add(product, quantity);
            }
        }

        public string GetItemsInShoppingCartToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in shoppingCart)
            {
                stringBuilder.Append($"Item Added = {item.Key}, Quantity ={item.Value}.\n");
            }

            return stringBuilder.ToString();
        }

        public void RemoveItemFromShoppingCart(string product, int quantity)
        {
            if (shoppingCart.ContainsKey(product))
            {
                var existingQuantity = shoppingCart[product];

                if (existingQuantity < quantity)
                    shoppingCart.Remove(product);
                else
                {
                    existingQuantity -= quantity;
                    shoppingCart[product] = existingQuantity;
                }
            }
        }
    }
}
