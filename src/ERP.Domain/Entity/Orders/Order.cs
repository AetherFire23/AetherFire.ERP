using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity.Orders;

public class Order : EntityBase
{
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public ICollection<OrderProductLine> OrderProductLines { get; set; } = [];

    public void AddProduct(Product product, int quantity)
    {
        var orderProductLine = new OrderProductLine
        {
            Product = product,
            QuantityOrdered = quantity,
            Order = this,
        };

        this.OrderProductLines.Add(orderProductLine);
    }
}