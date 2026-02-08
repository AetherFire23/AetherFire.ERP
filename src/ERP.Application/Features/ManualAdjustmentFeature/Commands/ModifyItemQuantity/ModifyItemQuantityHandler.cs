using AetherFire23.ERP.Domain.Entity;
using ERP.Practical;
using ERP.Practical.Repositories;
using Mediator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ERP.Application.Features.ManualAdjustmentFeature.Commands.ModifyItemQuantity;

public class ModifyItemQuantityHandler : IRequestHandler<ModifyItemQuantityRequest>
{
    private readonly ErpContext _erpContext;
    private readonly WarehouseRepository _warehouseRepository;
    private readonly ILogger<ModifyItemQuantityHandler> _logger;

    public ModifyItemQuantityHandler(ErpContext erpContext, WarehouseRepository warehouseRepository,
        ILogger<ModifyItemQuantityHandler> logger)
    {
        _erpContext = erpContext;
        _warehouseRepository = warehouseRepository;
        _logger = logger;
    }

    public async ValueTask<Unit> Handle(ModifyItemQuantityRequest request, CancellationToken cancellationToken)
    {
        ProductItem? productItem =
            await _warehouseRepository.GetProductItemInWarehouse(request.WarehouseId, request.ProductId);

        if (productItem is null)
        {
            _logger.LogInformation("Product item not found, creating one...");
            Product product = _erpContext.Products.First(p => p.Id == request.ProductId);
            
            Warehouse warehouse = await _erpContext.Warehouses.FindAsync(request.WarehouseId) ??
                                  throw new Exception("Not found");
            
            warehouse.AddProductItem(product, request.NewQuantity);
        }
        else
        {
            _logger.LogInformation("Product item found. setting new quantity.");
            productItem.Quantity = request.NewQuantity;
        }

        await _erpContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}