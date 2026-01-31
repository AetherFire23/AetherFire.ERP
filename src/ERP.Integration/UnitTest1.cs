using System.Diagnostics;
using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using ERP.Infrastructure.Contexts;
using Xunit.Abstractions;

namespace ERP.Integration;

public class UnitTest1 : ErpIntegrationTestBase
{
    public UnitTest1(ITestOutputHelper output) : base(output)
    {
        
    }

    [Fact]
    public async Task Test2()
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

        Assert.NotEmpty(base.Context.Users);
        Assert.NotEmpty(base.Context.Companies);
    }
}