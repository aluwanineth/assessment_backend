using ParkRunners.Core.Dtos.Request.MenuItemRequest;
using ParkRunners.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Contracts.MenuItem
{
    public interface IUpdateMenuItem : IRequestHandler<UpdateMenuItemRequest, ServiceResponse>
    {
    }
}
