using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Command
{
    internal class ProductInventoryRepository : IProductInventoryRepository
    {
        private Dictionary<string, int> productInventory;

        private readonly int laptopDefaultAvailable = 500;
        private readonly int mobileDefaultAvailable = 100;
        private readonly int iPodDefaultAvailable = 50;

        public ProductInventoryRepository()
        {
            productInventory = new Dictionary<string, int>
            {
                { "Laptop", laptopDefaultAvailable },
                { "Mobile", mobileDefaultAvailable },
                { "IPod", iPodDefaultAvailable }
            };
        }

        public void AddProductToInventory(string product, int quantity)
        {
            var existingQuantity = productInventory[product];

            existingQuantity += quantity;

            productInventory[product] = existingQuantity;
        }

        public string GetProductInventoryItemsAvailablesToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in productInventory)
            {
                stringBuilder.Append($"Inventry Item = {item.Key}, Available Quantity ={item.Value}.\n");
            }

            return stringBuilder.ToString();
        }

        public void RemoveProductFromInventory(string product, int quantity)
        {
            var existingQuantity = productInventory[product];

            existingQuantity -= quantity;

            productInventory[product] = existingQuantity;
        }
    }
}
