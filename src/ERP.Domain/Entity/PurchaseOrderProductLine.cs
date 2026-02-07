using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class PurchaseOrderProductLine : EntityBase
{
    public Guid PurchaseOrderId { get; set; }
    public PurchaseOrder PurchaseOrder { get; set; } = null!;

    public ICollection<PurchaseOrderProductLineReserveForOrder> PurcherOrderProductLineReserveForOrders { get; set; } = [];

}