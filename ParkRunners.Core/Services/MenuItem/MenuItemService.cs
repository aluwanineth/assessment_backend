using ParkRunners.Core.Contracts;
using ParkRunners.Core.Contracts.Gateways.Repositories;
using ParkRunners.Core.Contracts.MenuItem;
using ParkRunners.Core.Dtos.Request.MenuItemRequest;
using ParkRunners.Core.Dtos.Response;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkRunners.Core.Services.MenuItem
{
    public sealed class MenuItemService : ICreateMenuItem, IGetMenuItem, IUpdateMenuItem,
        IGetMenuItemById, IDeleteMenuItem, IGetMenusByRole
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public async Task<bool> HandleAsync(CreateMenuItemRequest message, IOutputPort<ServiceResponse> outputPort)
        {
            var response = await _menuItemRepository.AddMenuItem(message.ClientSideId,message.Label, message.DisplayOrder);
            outputPort.Handle(response.Success ? new ServiceResponse(response.Id, true) : new ServiceResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }

        public async Task<bool> HandleAsync(GetMenuItemRequest message, IOutputPort<GetMenuItemResponse> outputPort)
        {
            var response = await _menuItemRepository.GetMenuItem();
            outputPort.Handle(new GetMenuItemResponse(response, true, null));

            return true;
        }

        public async Task<bool> HandleAsync(UpdateMenuItemRequest message, IOutputPort<ServiceResponse> outputPort)
        {
            var response = await _menuItemRepository.UpdateMenuItem(message.Id,message.ClientSideId, message.Label, message.DisplayOrder);
            outputPort.Handle(response.Success ? new ServiceResponse(response.Id, true)
                : new ServiceResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }

        public async Task<bool> HandleAsync(DeleteMenuItemRequest message, IOutputPort<ServiceResponse> outputPort)
        {
            var response = await _menuItemRepository.DeleteMenuItem(message.Id);
            outputPort.Handle(response.Success ? new ServiceResponse(response.Id, true)
                : new ServiceResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }

        public async Task<bool> HandleAsync(GetMenuItemByIdRequest message, IOutputPort<GetMenuItemByIdResponse> outputPort)
        {
            var response = await _menuItemRepository.GetMenuItemById(message.Id);
            outputPort.Handle(new GetMenuItemByIdResponse(response, true, null));

            return true;
        }

        public async Task<bool> HandleAsync(GetMenuItemsByRoleRequest message, IOutputPort<GetMenuItemByRoleResponse> outputPort)
        {
            var response = await _menuItemRepository.GetMenus(message.ClientSideId);
            outputPort.Handle(new GetMenuItemByRoleResponse(response, true, null));

            return true;
        }
    }
}
