namespace ERP.Scenarios.MoveToCommons;

[AttributeUsage(AttributeTargets.Class)]
public class ScenarioAttribute : Attribute
{
    public string ScenarioName { get; init; }

    public ScenarioAttribute(string scenarioName)
    {
        ScenarioName = scenarioName;
    }
}