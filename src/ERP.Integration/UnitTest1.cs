using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using Xunit.Abstractions;

namespace ERP.Integration;

public class UnitTest1 : ErpIntegrationTestBase
{
    /// <summary>
    /// Passing the testoutput provider in the output.
    /// </summary>
    /// <param name="output"></param>
    public UnitTest1(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public async Task Test1()
    {
        await Mediator.Send(new CreateCompanyRequest
        {
            CompanyName = "FredCo",
            AdminUserName = "admin"
        });

        Assert.NotEmpty(base.Context.Companies);
    }
}