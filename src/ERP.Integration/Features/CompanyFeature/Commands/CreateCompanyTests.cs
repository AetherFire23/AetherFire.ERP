using ERP.Application.Features.CompanyFeature.Commands.CreateCompany;
using Xunit.Abstractions;

namespace ERP.Integration.Features.CompanyFeature.Commands;

public class CreateCompanyTests : ErpIntegrationTestBase
{
    public CreateCompanyTests(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public async Task GivenUser_CreatesACompany_ThenTheCompanyExists()
    {
        await Mediator.Send(new CreateCompanyRequest
        {
            CompanyName = "FredCo",
            AdminUserName = "admin",
            Password = "BONJOUR"
        });

        Assert.NotEmpty(base.Context.Companies);
    }

    [Fact]
    public async Task GivenUser_CreatesACompany_ThenTheUserExists()
    {
        await Mediator.Send(new CreateCompanyRequest
        {
            CompanyName = "FredCo",
            AdminUserName = "admin",
            Password = "Bonjour",
        });

        Assert.NotEmpty(base.Context.Users);
    }
}