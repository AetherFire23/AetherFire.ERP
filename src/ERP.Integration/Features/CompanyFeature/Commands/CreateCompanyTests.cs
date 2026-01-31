using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using Xunit.Abstractions;

namespace ERP.Integration.Features.CreateCompany.Commands;

public class CreateCompanyTests : ErpIntegrationTestBase
{
    public CreateCompanyTests(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public async Task GivenAnAdmin_CreatesACompany_ThenThe_CompanyExists()
    {
        await Mediator.Send(new CreateCompanyRequest
        {
            CompanyName = "FredCo",
            AdminUserName = "admin"
        });

        Assert.NotEmpty(base.Context.Companies);
    }
}