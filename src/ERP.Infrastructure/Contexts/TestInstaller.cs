using AetherFire23.Commons.Composition;
using ERP.Application.Installation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Infrastructure.Contexts;

public class TestInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection, IConfiguration configuration)
    {
        // TODO: add specific installer override support an interface registration instead of having to do this for when i 
        serviceCollection.AddDbContext<IErpContext, ErpContext>();
    }
}