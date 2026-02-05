using ERP.Scenarios.MoveToCommons;
using Microsoft.Playwright;

namespace ERP.Scenarios.Scenarios;

[Scenario("SeededCompany")]
public class TestScenarioLaunch : ScenarioBase
{
    public override async Task RunScenario(IPlaywright playwright)
    {
        var p = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions()
        {
            Headless = false,
        });

        var s = await p.NewPageAsync();

        // FRONTEND URL LOCATI
        await s.GotoAsync("http://localhost:5173");
    }
}