using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity.PurchaseOrderring;

public class PurchaseOrder : EntityBase
{
    public ICollection<PurchaseOrderProductLine> PurchaseOrderProductLines { get; set; } = [];
}