using Microsoft.Extensions.DependencyInjection;

namespace ERP.Scenarios.MoveToCommons;

public static class ScenarioMonsieur
{
    public static void InstallScenarioLauncher(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ScenarioLauncher>();
    }

    public static async Task LaunchScenarioBrowser(this IServiceProvider serviceProvider, string scenarionName)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var scenarioLauncher = scope.ServiceProvider.GetRequiredService<ScenarioLauncher>();

            await scenarioLauncher.LaunchScenario(scenarionName);
        }
    }
}