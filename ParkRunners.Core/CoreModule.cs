using Autofac;
using ParkRunners.Core.Contracts.MenuItem;
using ParkRunners.Core.Services.MenuItem;

namespace ParkRunners.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
          
            builder.RegisterType<MenuItemService>().As<ICreateMenuItem>().InstancePerLifetimeScope();
            builder.RegisterType<MenuItemService>().As<IGetMenuItem>().InstancePerLifetimeScope();
            builder.RegisterType<MenuItemService>().As<IGetMenuItemById>().InstancePerLifetimeScope();
            builder.RegisterType<MenuItemService>().As<IUpdateMenuItem>().InstancePerLifetimeScope();
            builder.RegisterType<MenuItemService>().As<IDeleteMenuItem>().InstancePerLifetimeScope();
        }
    }
}
