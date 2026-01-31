using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class ProductItem : EntityBase
{
    public required Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public required Guid WarehouseId { get; set; }
    public Warehouse? Warehouse { get; set; }

    public required int Quantity { get; set; }

    public static ProductItem Create(Guid productId, Guid warehouseId)
    {
        var productItem = new ProductItem
        {
            ProductId = productId,
            Quantity = 0,
            WarehouseId = warehouseId
        };

        return productItem;
    }
}