using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvertoryServices.Models;
using InvertoryServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvertoryServices.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices _services;

        public InventoryController(IInventoryServices services)
        {
            _services = services;
        }


        [HttpPost]
        [Route("AddInventory")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            InventoryItems invertoryItems = _services.AddInventoryItems(items);

            if(invertoryItems == null)
            {
                return NotFound();
            }

            return invertoryItems;

        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult <Dictionary<string, InventoryItems>> GetInventoryItems()
        {
            var inventoryItems = _services.GetInventoryItems();
            if (inventoryItems.Count == 0)
            {
                return NotFound();
            }
            return inventoryItems;
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public ActionResult<string> Delete(string id)
        {

            var inventoryItems = _services.DeleteInventory(id);
            return id;


        }

    }
}