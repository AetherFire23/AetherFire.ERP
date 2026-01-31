using AetherFire23.ERP.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ERP.Practical.Repositories;

public class ProductItemRepository
{
    private readonly ErpContext _productItemRepository;

    public ProductItemRepository(ErpContext productItemRepository)
    {
        _productItemRepository = productItemRepository;
    }

    public async Task<ProductItem?> GetProductItemInWarehouse(Guid warehouseId, Guid productId)
    {
        var productItem = await _productItemRepository.ProductItems
            .Where(x => x.WarehouseId == warehouseId)
            .FirstOrDefaultAsync(x => x.ProductId == productId);

        return productItem;
    }
}