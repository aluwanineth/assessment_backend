using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRunners.Api.Models.Responses.MenuItem
{
    public class GetMenuItemByIdResponse
    {
        public Core.Models.Entities.MenuItem MenuItem { get; }

        public GetMenuItemByIdResponse(Core.Models.Entities.MenuItem menuItem)
        {
            MenuItem = menuItem;
        }
    }
}
