using AetherFire23.Commons.Composition;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Application.Installation;

public class MediatorInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddMediator(o =>
        {
            o.Assemblies = [typeof(MediatorInstaller).Assembly];


            /* VERY IMPORTANT that this is added as scoped.
             Will work in test assemblies but not in aspnet core
             */

            o.ServiceLifetime = ServiceLifetime.Scoped;
        });
    }
}