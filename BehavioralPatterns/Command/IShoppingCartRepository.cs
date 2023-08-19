using System.Collections.Generic;

namespace BehavioralPatterns.Command
{
    internal interface IShoppingCartRepository
    {
        void AddItemToShoppingCart(string product, int quantity);
        string GetItemsInShoppingCartToString();
        void RemoveItemFromShoppingCart(string product, int quantity);
    }
}