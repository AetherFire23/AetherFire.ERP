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

        var browser = await pw.Chromium.LaunchAsync(new BrowserTypeLaunchOptions()
        {
            Headless = false
        });

       var page = await  browser.NewPageAsync();
       await page.GotoAsync("http://localhost:5173");

       // await ((ScenarioBase)Activator.CreateInstance(scenarios)).LaunchScenario();

       // run scenario 
    }
}