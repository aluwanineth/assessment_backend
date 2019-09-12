using ParkRunners.Core.Contracts;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Request.MenuItemRequest
{
    public class GetMenuItemByIdRequest : IRequest<GetMenuItemByIdResponse>
    {
        public int Id { get; set; }

        public GetMenuItemByIdRequest(int id)
        {
            Id = id;
        }
    }
}
