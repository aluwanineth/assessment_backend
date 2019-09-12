using ParkRunners.Api.Serialization;
using ParkRunners.Core.Contracts;
using ParkRunners.Core.Dtos.Response;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ParkRunners.Api.Presenters.MenuItem
{
    public class MenuItemPresenter : IOutputPort<ServiceResponse>, IOutputPort<GetMenuItemResponse>,
         IOutputPort<GetMenuItemByIdResponse>
    {
        public JsonContentResult ContentResult { get; }

        public MenuItemPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(ServiceResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = JsonSerializer.SerializeObject(response);
        }

        void IOutputPort<GetMenuItemResponse>.Handle(GetMenuItemResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Models.Responses.MenuItem.GetMenuItemResponse(response.MenuItems)) : JsonSerializer.SerializeObject(response.Message);
        }



        public void Handle(GetMenuItemByIdResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = response.Success ? JsonSerializer.SerializeObject(new Models.Responses.MenuItem.GetMenuItemByIdResponse(response.MenuItem)) : JsonSerializer.SerializeObject(response.Message);
        }
    }
}

