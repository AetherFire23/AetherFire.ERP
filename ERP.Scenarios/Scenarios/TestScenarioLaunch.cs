using ERP.Scenarios.MoveToCommons;
using Microsoft.Playwright;

namespace ERP.Scenarios.Scenarios;

[Scenario("SeededCompany")]
public class TestScenarioLaunch : ScenarioBase
{
    protected override async Task RunScenario(IPlaywright playwright)
    {
        await playwright.Chromium.LaunchAsync();
    }
}