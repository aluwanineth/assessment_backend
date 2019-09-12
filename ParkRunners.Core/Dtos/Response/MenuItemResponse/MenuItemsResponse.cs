using ParkRunners.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Response.MenuItemResponse
{
    public class MenuItemsResponse
    {
        public Menus Menus { get; set; }
    }

    public class Children
    {
        public int Id { get; set; }
        public Role ClientSideId { get; set; }
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public Role ClientSideId { get; set; }
        public string Label { get; set; }
        public DisplayOrder DisplayOrder { get; set; }
        public List<Children> Items { get; set; }
    }

    public class Menus
    {
        public int role { get; set; }
        public List<Item> items { get; set; }
    }
}
