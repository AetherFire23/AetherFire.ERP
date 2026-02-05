using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class Warehouse : EntityBase
{
    public required string WarehouseName { get; set; }

    public required Guid CompanyId { get; set; }

    public Company? Company { get; set; }

    public virtual ICollection<ProductItem> ProductItems { get; set; } = [];
}