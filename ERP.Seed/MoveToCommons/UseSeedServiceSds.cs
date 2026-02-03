using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;

namespace ERP.Seed.MoveToCommons;

public static class UseSeedServiceSds
{
    public static IEnumerable<Type> Seeded;

    public static void AddSeedServices(this IServiceCollection serviceCollection, Assembly assembly)
    {
        Seeded = ScanSeedersInAssembly(assembly);

        foreach (Type type in Seeded)
        {
            serviceCollection.AddScoped(type);
        }
    }

    public static void ExecuteSeedFromSeedName(this IServiceProvider serviceProvider, string seedName)
    {
        var seedServiceType = Seeded.Single(x => x.Name == seedName);

        using (var scope = serviceProvider.CreateScope())
        {
            scope.ServiceProvider.GetRequiredService<ILogger<Program>>()
                .LogInformation($"Executing {seedName} as seed. ");
            
            var s = (ISeeder)scope.ServiceProvider.GetRequiredService(seedServiceType);
            s.SetupSeeding().Wait();
        }
    }

    public static IEnumerable<Type> ScanSeedersInAssembly(Assembly assembly)
    {
        var types = assembly.GetTypes()
            .Where(t => typeof(ISeeder).IsAssignableFrom(t) && !t.IsInterface);

        return types;
    }
}