using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Chips", Active=true, DateOfLaunch=new DateTime(2022,06,24), FreeDelivery=false,Price=50},
                new MenuItem() {Id=2, Name="Sweets", Active=false, DateOfLaunch=new DateTime(2022,06,23), FreeDelivery=false,Price=300}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemByName(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Chips", Active=true, DateOfLaunch=new DateTime(2022,06,24), FreeDelivery=false,Price=50},
                new MenuItem() {Id=2, Name="Sweets", Active=false, DateOfLaunch=new DateTime(2022,06,23), FreeDelivery=false,Price=200}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
            
        }

    }
}
