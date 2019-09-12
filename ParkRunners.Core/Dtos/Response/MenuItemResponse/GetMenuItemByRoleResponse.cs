using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Response.MenuItemResponse
{
    public class GetMenuItemByRoleResponse : ResponseMessage
    {
        public Menus Menus { get; }
        public GetMenuItemByRoleResponse(Menus menus, bool success = false, string message = null) : base(success, message)
        {
            Menus = menus;
        }
    }
}
