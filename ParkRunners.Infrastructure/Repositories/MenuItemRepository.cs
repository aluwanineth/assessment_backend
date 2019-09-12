using Microsoft.EntityFrameworkCore;
using ParkRunners.Core.Contracts.Gateways.Repositories;
using ParkRunners.Core.Dtos;
using ParkRunners.Core.Dtos.Response.GatewayResponses.Repositories;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using ParkRunners.Core.Enums;
using ParkRunners.Core.Models.Entities;
using ParkRunners.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRunners.Infrastructure.Repositories
{
    public class MenuItemRepository : EfRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
        public async Task<Response> AddMenuItem(Role clientSideId, string label, DisplayOrder displayOrder)
        {
            try
            {
                var result = _appDbContext.MenuItemsReponse.FromSql("SQL_SCRIPT").ToList();
                var MenuItem = new MenuItem(0, clientSideId, label,displayOrder);
                await Add(MenuItem);
                return new Response(Guid.NewGuid().ToString(), true, null);
            }
            catch (Exception ex)
            {
                List<Error> errors = new List<Error>();
                var error = new Error("500", ex.Message);
                errors.Add(error);
                return new Response(Guid.NewGuid().ToString(), true, errors.Select(e => new Error(e.Code, e.Description)));
            }
        }
        public async Task<IEnumerable<MenuItem>> GetMenuItem()
        {
            return await ListAll();
        }
        public async Task<MenuItem> GetMenuItemById(int id)
        {
            return await GetById(id);
        }
        public async Task<Response> UpdateMenuItem(int id, Role clientSideId, string label, DisplayOrder displayOrder)
        {
            try
            {
                var MenuItem = new MenuItem(id, clientSideId,label, displayOrder);
                await Update(MenuItem);
                return new Response(Guid.NewGuid().ToString(), true, null);
            }
            catch (Exception ex)
            {
                List<Error> errors = new List<Error>();
                var error = new Error("500", ex.Message);
                errors.Add(error);
                return new Response(Guid.NewGuid().ToString(), true, errors.Select(e => new Error(e.Code, e.Description)));
            }
        }
        public async Task<Response> DeleteMenuItem(int id)
        {
            try
            {
                var entity = await GetById(id);
                await Delete(entity);
                return new Response(Guid.NewGuid().ToString(), true, null);
            }
            catch (Exception ex)
            {
                List<Error> errors = new List<Error>();
                var error = new Error("500", ex.Message);
                errors.Add(error);
                return new Response(Guid.NewGuid().ToString(), true, errors.Select(e => new Error(e.Code, e.Description)));
            }
        }

        public Task<Menus> GetMenus(Role clientSideId)
        {
            throw new NotImplementedException();
        }
    }
}