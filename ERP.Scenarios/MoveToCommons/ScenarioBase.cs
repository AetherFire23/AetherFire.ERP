using Microsoft.Extensions.DependencyInjection;
using Microsoft.Playwright;

namespace ERP.Scenarios.MoveToCommons;

public abstract class ScenarioBase
{
    public abstract Task RunScenario(IServiceScope scope, IPlaywright playwright);
}