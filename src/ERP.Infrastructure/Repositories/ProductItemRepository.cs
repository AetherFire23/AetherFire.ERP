using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using Microsoft.EntityFrameworkCore;

namespace ERP.Infrastructure.Repositories;

public class ProductItemRepository
{
    private readonly IErpContext _erpContext;

    public ProductItemRepository(IErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async Task<ProductItem?> GetProductItemFromWareHouseId(Guid warehouseId, Guid productId)
    {
        var productItem = await _erpContext.ProductItems
            .Where(x => x.WarehouseId == warehouseId)
            .FirstOrDefaultAsync(x => x.ProductId == productId);

        return productItem;
    }
}