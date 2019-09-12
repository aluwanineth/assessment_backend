using ParkRunners.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Response.MenuItemResponse
{
    public class GetMenuItemByIdResponse : ResponseMessage
    {
        public MenuItem MenuItem { get; }
        public GetMenuItemByIdResponse(MenuItem menuItem, bool success = false, string message = null) : base(success, message)
        {
            MenuItem = menuItem;
        }
    }
}