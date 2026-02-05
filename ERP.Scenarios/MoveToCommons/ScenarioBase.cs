using Microsoft.Playwright;

namespace ERP.Scenarios.MoveToCommons;

public abstract class ScenarioBase
{
    public abstract Task RunScenario(IPlaywright playwright);
}