using ParkRunners.Core.Contracts;
using ParkRunners.Core.Dtos.Response;
using ParkRunners.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Request.MenuItemRequest
{
    public class CreateMenuItemRequest : IRequest<ServiceResponse>
    {
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
        public Role ClientSideId { get; set; }
        public CreateMenuItemRequest(Role clientSideId, string label, DisplayOrder displayOrder)
        {
            ClientSideId = clientSideId;
            Label = label;
            DisplayOrder = displayOrder;
        }
    }
}
