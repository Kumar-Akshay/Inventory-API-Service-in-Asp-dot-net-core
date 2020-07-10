using InvertoryServices.Models;
using System.Collections.Generic;


namespace InvertoryServices.Services
{
    public class InventoryService : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryService()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();

        }
        public  InventoryItems AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);
            return items;
        }

        public string DeleteInventory(string itemname)
        {
            _inventoryItems.Remove(itemname);

            return itemname;
        }

        public  Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return _inventoryItems;
        }
    }
}
