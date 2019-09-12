using ParkRunners.Core.Enums;
using ParkRunners.Core.Shared;

namespace ParkRunners.Core.Models.Entities
{
    public class MenuItem : BaseEntity
    {
        public Role ClientSideId { get; set; }
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
        internal MenuItem() { }

        internal MenuItem(int id, Role clientSideId, string label, DisplayOrder displayOrder)
        {
            Id = id;
            ClientSideId = clientSideId;
            Label = label;
            DisplayOrder = DisplayOrder;
        }
    }


}
