using Autofac;
using ParkRunners.Core.Contracts.Gateways.Repositories;
using ParkRunners.Infrastructure.Repositories;

namespace ParkRunners.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MenuItemRepository>().As<IMenuItemRepository>().InstancePerLifetimeScope();
        }
    }
}
