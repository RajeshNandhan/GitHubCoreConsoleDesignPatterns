using System.Collections.Generic;

namespace BehavioralPatterns.Command
{
    internal interface IProductInventoryRepository
    {
        void AddProductToInventory(string product, int quantity);
        string GetProductInventoryItemsAvailablesToString();
        void RemoveProductFromInventory(string product, int quantity);
    }
}
