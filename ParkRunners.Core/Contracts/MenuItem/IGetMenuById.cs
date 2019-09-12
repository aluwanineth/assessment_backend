using ParkRunners.Core.Dtos.Request.MenuItemRequest;
using ParkRunners.Core.Dtos.Response;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Contracts.MenuItem
{
    public interface IGetMenuItemById : IRequestHandler<GetMenuItemByIdRequest, GetMenuItemByIdResponse>
    {
    }
}
