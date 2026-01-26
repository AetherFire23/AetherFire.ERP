using AetherFire23.ERP.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ERP.Application.Installation;

public interface IErpContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
   
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}