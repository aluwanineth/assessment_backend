using ParkRunners.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Response.MenuItemResponse
{
    public class GetMenuItemResponse : ResponseMessage
    {
        public IEnumerable<MenuItem> MenuItems { get; }
        public GetMenuItemResponse(IEnumerable<MenuItem> menuItems, bool success = false, string message = null) : base(success, message)
        {
            MenuItems = menuItems;
        }
    }
}