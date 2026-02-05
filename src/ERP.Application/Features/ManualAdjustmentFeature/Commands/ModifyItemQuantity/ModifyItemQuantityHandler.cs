using AetherFire23.ERP.Domain.Entity;
using ERP.Practical;
using ERP.Practical.Repositories;
using Mediator;
using Microsoft.Extensions.Logging;

namespace ERP.Application.Features.ManualAdjustmentFeature.Commands.ModifyItemQuantity;

public class ModifyItemQuantityHandler : IRequestHandler<ModifyItemQuantityRequest>
{
    private readonly ErpContext _erpContext;
    private readonly ProductItemRepository _productItemRepository;
    private readonly ILogger<ModifyItemQuantityHandler> _logger;

    public ModifyItemQuantityHandler(ErpContext erpContext, ProductItemRepository productItemRepository,
        ILogger<ModifyItemQuantityHandler> logger)
    {
        _erpContext = erpContext;
        _productItemRepository = productItemRepository;
        _logger = logger;
    }

    public async ValueTask<Unit> Handle(ModifyItemQuantityRequest request, CancellationToken cancellationToken)
    {
        ProductItem? productItem =
            await _productItemRepository.GetProductItemInWarehouse(request.WarehouseId, request.ProductId);

        if (productItem is null)
        {
            _logger.LogInformation("Product item not found, creating one...");
            _erpContext.ProductItems.Add(
                ProductItem.Create(request.ProductId, request.WarehouseId, request.NewQuantity));
        }
        else
        {
            _logger.LogInformation("Product item found.");
            productItem.Quantity = request.NewQuantity;
        }

        await _erpContext.SaveChangesAsync();

        return Unit.Value;
    }
}