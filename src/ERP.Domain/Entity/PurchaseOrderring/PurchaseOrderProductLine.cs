using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity.PurchaseOrderring;

public class PurchaseOrderProductLine : EntityBase
{
    public Guid PurchaseOrderId { get; set; }
    public PurchaseOrder PurchaseOrder { get; set; } = null!;

    public required Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public ICollection<PurchaseOrderProductLineReserveForOrder> PurcherOrderProductLineReserveForOrders { get; set; } =
        [];
    
    public int QuantityOrdered { get; set; }
}