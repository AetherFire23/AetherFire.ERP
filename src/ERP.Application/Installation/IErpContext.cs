using AetherFire23.ERP.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ERP.Application.Installation;

public interface IErpContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductItem> ProductItems { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}