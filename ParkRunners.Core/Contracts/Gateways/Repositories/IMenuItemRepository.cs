using ParkRunners.Core.Dtos.Response.GatewayResponses.Repositories;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using ParkRunners.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkRunners.Core.Contracts.Gateways.Repositories
{
    public interface IMenuItemRepository : IRepository<Models.Entities.MenuItem>
    {
        Task<Menus> GetMenus(Role clientSideId);
        Task<Response> AddMenuItem(Role clientSideId, string label, DisplayOrder displayOrder);
        Task<IEnumerable<Models.Entities.MenuItem>> GetMenuItem();
        Task<Models.Entities.MenuItem> GetMenuItemById(int id);
        Task<Response> UpdateMenuItem(int id, Role clientSideId, string label, DisplayOrder displayOrder);
        Task<Response> DeleteMenuItem(int id);
    }
}