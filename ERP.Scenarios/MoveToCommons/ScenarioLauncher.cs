using System.Reflection;
using Microsoft.Playwright;

namespace ERP.Scenarios.MoveToCommons;

public class ScenarioLauncher
{
    public async Task LaunchScenario(string scenarioName)
    {
        // get scenario classes
        var scenarios = typeof(ScenarioLauncher).Assembly.GetTypes()
            .Where(t => !t.IsAbstract
                        && !t.IsInterface
                        && typeof(ScenarioBase).IsAssignableFrom(t)
                        && t.GetCustomAttribute<ScenarioAttribute>() is not null
            )
            // With the appropriate attribute
            .First(t => t.GetCustomAttribute<ScenarioAttribute>().ScenarioName == scenarioName);

        // prepare Playwright browser 

        var pw = await Playwright.CreateAsync();

       await ((ScenarioBase)Activator.CreateInstance(scenarios)).RunScenario(pw);

       // run scenario 
    }
}