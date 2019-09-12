using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRunners.Api.Models.Responses.MenuItem
{
    public class GetMenuItemResponse
    {
        public IEnumerable<Core.Models.Entities.MenuItem> MenuItems { get; }

        public GetMenuItemResponse(IEnumerable<Core.Models.Entities.MenuItem> menuItems)
        {
            MenuItems = menuItems;
        }
    }
}
