using AetherFire23.ERP.Domain.Entity;
using ERP.Infrastructure.Contexts;

namespace ERP.Integration;

public class UnitTest1 : ErpIntegrationTestBase
{
    [Fact]
    public void Test1()
    {
        var ctx = GetService<ErpContext>();

        ctx.Users.Add(new User()
        {
            
        });
        
        ctx.SaveChanges();
    }
}