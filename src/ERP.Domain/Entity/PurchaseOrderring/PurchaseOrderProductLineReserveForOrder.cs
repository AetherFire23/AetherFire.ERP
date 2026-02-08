using AetherFire23.Commons.Domain.Entities;
using AetherFire23.ERP.Domain.Entity.Orders;

namespace AetherFire23.ERP.Domain.Entity.PurchaseOrderring;

/// <summary>
/// Reserves a certain quantity 
/// </summary>
public class PurchaseOrderProductLineReserveForOrder : EntityBase
{
    public required Guid PurchaseOrderProductLineId { get; set; }
    public required PurchaseOrderProductLine PurchaseOrderProductLine { get; set; } = null!;

    public required Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public required int Quantity { get; set; }
}