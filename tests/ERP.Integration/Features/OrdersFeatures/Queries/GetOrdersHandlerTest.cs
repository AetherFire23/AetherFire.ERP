using ERP.Application.Features.OrdersFeatures.Queries;
using JetBrains.Annotations;
using Xunit.Abstractions;

namespace ERP.Integration.Features.OrdersFeatures.Queries;

[TestSubject(typeof(GetOrdersHandler))]
public class GetOrdersHandlerTest : ErpIntegrationTestBase
{
    public GetOrdersHandlerTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public void Bloop()
    {
        
    }
}