using ParkRunners.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRunners.Api.Models.Requests.MenuItem
{
    public class CreateMenuItemRequest
    {
        public Role ClientSideId { get; set; }
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
    }
}
