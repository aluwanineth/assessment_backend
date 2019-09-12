using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkRunners.Api.Presenters.MenuItem;
using ParkRunners.Core.Contracts.MenuItem;
using ParkRunners.Core.Dtos.Request.MenuItemRequest;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkRunners.Api.Controllers
{
    [Route("api/[controller]")]
    public class MenuItemsController : Controller
    {
        private readonly ICreateMenuItem _createMenuItem;
        private readonly IGetMenuItem _getMenuItem;
        private readonly IUpdateMenuItem _updateMenuItem;
        private readonly MenuItemPresenter _MenuItemPresenter;
        private readonly IDeleteMenuItem _deleteMenuItem;
        private readonly IGetMenuItemById _getMenuItemById;

        public MenuItemsController(ICreateMenuItem createMenuItem,
            MenuItemPresenter MenuItemPresenter,
            IGetMenuItem getMenuItem,
            IUpdateMenuItem updateMenuItem,
            IDeleteMenuItem deleteMenuItem,
            IGetMenuItemById getMenuItemById)
        {
            _MenuItemPresenter = MenuItemPresenter;
            _createMenuItem = createMenuItem;
            _getMenuItem = getMenuItem;
            _updateMenuItem = updateMenuItem;
            _deleteMenuItem = deleteMenuItem;
            _getMenuItemById = getMenuItemById;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            await _getMenuItem.HandleAsync(new GetMenuItemRequest(), _MenuItemPresenter);
            return _MenuItemPresenter.ContentResult;
        }

        // get api/accounts

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            await _getMenuItemById.HandleAsync(new GetMenuItemByIdRequest(id), _MenuItemPresenter);
            return _MenuItemPresenter.ContentResult;
        }
        // POST api/accounts
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Models.Requests.MenuItem.CreateMenuItemRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _createMenuItem.HandleAsync(new CreateMenuItemRequest(request.ClientSideId,request.Label, request.DisplayOrder), _MenuItemPresenter);
            return _MenuItemPresenter.ContentResult;
        }

        // PUT api/accounts
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Models.Requests.MenuItem.UpdateMenuItemRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _updateMenuItem.HandleAsync(new UpdateMenuItemRequest(request.Id, request.ClientSideId, request.Label, request.DisplayOrder), _MenuItemPresenter);
            return _MenuItemPresenter.ContentResult;
        }

        // PUT api/accounts
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _deleteMenuItem.HandleAsync(new DeleteMenuItemRequest(id), _MenuItemPresenter);
            return _MenuItemPresenter.ContentResult;
        }

    }
}
