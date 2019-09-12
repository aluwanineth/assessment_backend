using ParkRunners.Core.Contracts;
using ParkRunners.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Request.MenuItemRequest
{
    public class DeleteMenuItemRequest : IRequest<ServiceResponse>
    {
        public int Id { get; set; }

        public DeleteMenuItemRequest(int id)
        {
            Id = id;
        }
    }
}
