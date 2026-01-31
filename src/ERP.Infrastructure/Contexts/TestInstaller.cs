using AetherFire23.Commons.Composition;
using ERP.Practical.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Infrastructure.Contexts;

public class TestInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddScoped<ProductItemRepository>();
    }
}