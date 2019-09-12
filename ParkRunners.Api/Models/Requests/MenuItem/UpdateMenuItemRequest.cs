using ParkRunners.Core.Enums;

namespace ParkRunners.Api.Models.Requests.MenuItem
{
    public class UpdateMenuItemRequest
    {
        public int Id { get; set; }
        public Role ClientSideId { get; set; }
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
    }
}
