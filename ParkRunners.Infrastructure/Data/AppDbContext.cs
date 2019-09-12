using Microsoft.EntityFrameworkCore;
using ParkRunners.Core.Dtos.Response.MenuItemResponse;
using ParkRunners.Core.Models.Entities;
using ParkRunners.Core.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ParkRunners.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Dashboard",
                Created = DateTime.Now,

            },
            new MenuItem
            {
                Id = 2,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Events",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 3,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Members",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 4,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Club",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 5,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Online Store",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 6,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Sponsors",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 7,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Event,
                Label = "Manage Event",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 8,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Event,
                Label = "Add Events",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 9,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Clubs,
                Label = "Manage Club",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 10,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Clubs,
                Label = "Add Club",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 11,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Member,
                Label = "Manage Member",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 12,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Member,
                Label = "Add Member",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 13,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.OnlineStore,
                Label = "Manage Online Store",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 14,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.OnlineStore,
                Label = "Add Online Store",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 15,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Sponsor,
                Label = "Manage ",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 16,
                ClientSideId = Core.Enums.Role.Coordinators,
                DisplayOrder = Core.Enums.DisplayOrder.Sponsor,
                Label = "Add Sponsor",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 17,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Dashboard",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 18,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Events",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 19,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Members",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 20,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Club",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 21,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Online Store",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 22,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Menu,
                Label = "Sponsors",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 23,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Event,
                Label = "Manage Event",
                Created = DateTime.Now
            },
            new MenuItem
            {
                Id = 24,
                ClientSideId = Core.Enums.Role.Participants,
                DisplayOrder = Core.Enums.DisplayOrder.Event,
                Label = "Add Events",
                Created = DateTime.Now
            });
        }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbQuery<MenuItemsResponse> MenuItemsReponse { get; set; }
        public override int SaveChanges()
        {
            AddAuitInfo();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddAuitInfo();
            return await base.SaveChangesAsync();
        }

        private void AddAuitInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).Created = DateTime.Now;
                }
                ((BaseEntity)entry.Entity).Modified = DateTime.Now;
            }
        }
    }
}
