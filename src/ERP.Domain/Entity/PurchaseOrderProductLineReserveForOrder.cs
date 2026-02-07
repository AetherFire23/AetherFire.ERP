using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class PurchaseOrderProductLineReserveForOrder : EntityBase
{
    public required Guid PurchaseOrderProductLineId { get; set; }
    public required PurchaseOrderProductLine PurchaseOrderProductLine { get; set; } = null!;

    public required Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public required int Quantity { get; set; }
}