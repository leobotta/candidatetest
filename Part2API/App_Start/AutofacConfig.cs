using Autofac;
using BusinessLayer;
using DataLayer;
using Entities.Abstractions;

namespace Part2API
{
    public class AutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder bd)
        {
            base.Load(bd);

            bd.RegisterType<DeveloperDA>().As<IDeveloperDA>().InstancePerLifetimeScope();

            bd.RegisterType<DeveloperBC>().As<IDeveloperBC>().InstancePerLifetimeScope();
        }
    }
}