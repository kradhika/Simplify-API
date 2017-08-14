using Autofac;
using DH.Simplify.Infrastructure.Persistence;

namespace DH.Simplify.Infrastructure.DI
{
    public static class DependenciesInstaller
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            //DH.Simplify.Core.Application            

            //DH.Simplify.Infrastructure.Persistence.Repositories            

            builder.RegisterType<SimplifyContext>().AsSelf().InstancePerRequest();
        }
    }
}
