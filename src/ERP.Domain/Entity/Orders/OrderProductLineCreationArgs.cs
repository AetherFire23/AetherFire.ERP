namespace AetherFire23.ERP.Domain.Entity.Orders;

public class OrderProductLineCreationArgs
{
    public required Guid ProductId { get; set; }
    public required int QuantityOrdered { get; set; }
}