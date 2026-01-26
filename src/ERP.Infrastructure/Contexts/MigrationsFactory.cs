using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ERP.Infrastructure.Contexts;

// TODO: check if Commons can handle a generic implementation 
public class MigrationsFactory : IDesignTimeDbContextFactory<ErpContext>
{
    public ErpContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<ErpContext>()
            .UseNpgsql("Host=localhost;Database=FakeDesignTime;Username=fake;Password=fake;")
            .Options;

        return new ErpContext(options);
    }
}