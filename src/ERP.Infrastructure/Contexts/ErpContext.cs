using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using Microsoft.EntityFrameworkCore;

namespace ERP.Infrastructure.Contexts;

public class ErpContext : DbContext, IErpContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }

    public ErpContext(DbContextOptions<ErpContext> options) : base(options)
    {
    }
}