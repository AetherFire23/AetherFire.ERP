using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace ERP.Integration;

public class TestLogger : ILogger
{
    private readonly ITestOutputHelper _testOutputHelper;

    public TestLogger(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception,
        Func<TState, Exception?, string> formatter)
    {
        _testOutputHelper.WriteLine(state.ToString());
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }
}