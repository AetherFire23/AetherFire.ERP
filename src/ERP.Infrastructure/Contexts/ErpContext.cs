using AetherFire23.ERP.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ERP.Infrastructure.Contexts;

public class ErpContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public ErpContext(DbContextOptions<ErpContext> options)
    {
    }
}