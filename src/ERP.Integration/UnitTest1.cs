using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using ERP.Infrastructure.Contexts;

namespace ERP.Integration;

public class UnitTest1 : ErpIntegrationTestBase
{
    [Fact]
    public async Task Test1()
    {
        await Mediator.Send(new CreateCompanyRequest()
        {
            CompanyName = "FredCo",
            AdminUserName = "admin"
        });
        
        
    }
}