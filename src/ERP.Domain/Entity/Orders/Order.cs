using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity.Orders;

public class Order : EntityBase
{
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public ICollection<OrderProductLine> OrderProductLines { get; private set; } = [];

    public OrderProductLine AddOrderProductLine(OrderProductLineCreationArgs args)
    {
        var orderProductLine = new OrderProductLine
        {
            OrderId = this.Id,
            ProductId = args.ProductId,
            QuantityOrdered = args.QuantityOrdered,
        };

        this.OrderProductLines.Add(orderProductLine);

        return orderProductLine;
    }
}