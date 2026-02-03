using Microsoft.Playwright;

namespace ERP.Scenarios.MoveToCommons;

public abstract class ScenarioBase
{
    public async Task LaunchScenario()
    {
        await RunScenario(await Playwright.CreateAsync());
    }

    protected abstract Task RunScenario(IPlaywright playwright);
}