using InvertoryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvertoryServices.Services
{
    public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);

        Dictionary<string, InventoryItems> GetInventoryItems();

        string DeleteInventory(string id);


    }
}
