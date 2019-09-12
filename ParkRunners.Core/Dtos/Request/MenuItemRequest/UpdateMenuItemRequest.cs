using ParkRunners.Core.Contracts;
using ParkRunners.Core.Dtos.Response;
using ParkRunners.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Request.MenuItemRequest
{
    public class UpdateMenuItemRequest : IRequest<ServiceResponse>
    {
        public int Id { get; set; }
        public Role ClientSideId { get; set; }
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
        public UpdateMenuItemRequest(int id, Role clientSideId, string label, DisplayOrder displayOrder)
        {
            ClientSideId = clientSideId;
            Id = id;
            Label = label;
            DisplayOrder = DisplayOrder;
        }
    }
}