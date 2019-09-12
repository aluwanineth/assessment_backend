using ParkRunners.Core.Contracts;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using ParkRunners.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Request.MenuItemRequest
{
    public class GetMenuItemsByRoleRequest : IRequest<GetMenuItemByRoleResponse>
    {
        public Role ClientSideId { get; set; }

        public GetMenuItemsByRoleRequest(Role clientSideId)
        {
            ClientSideId = clientSideId;
        }
    }
}
