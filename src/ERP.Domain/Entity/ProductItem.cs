using AetherFire23.Commons.Domain.Entities;

namespace AetherFire23.ERP.Domain.Entity;

public class ProductItem : EntityBase
{
    public required Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public required Guid WarehouseId { get; set; }
    public Warehouse? Warehouse { get; set; }

    public int Quantity { get; set; }

    public ProductItem(int quantity)
    {
        this.Quantity = quantity;
    }

    public static ProductItem Create(Guid productId, Guid warehouseId, int initialQuantity)
    {
        var productItem = new ProductItem(initialQuantity)
        {
            ProductId = productId,
            Quantity = initialQuantity,
            WarehouseId = warehouseId
        };

        return productItem;
    }
}