using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using ERP.Practical;
using ERP.Practical.Repositories;
using Mediator;

namespace ERP.Application.Features.ManualAdjustmentFeature.Commands.AddProductItemQuantity;

public class ModifyItemQuantityHandler : IRequestHandler<ModifyItemQuantityRequest>
{
    private readonly ErpContext _erpContext;
    private readonly ProductItemRepository _productItemRepository;

    public ModifyItemQuantityHandler(ErpContext erpContext, ProductItemRepository productItemRepository)
    {
        _erpContext = erpContext;
        _productItemRepository = productItemRepository;
    }

    public async ValueTask<Unit> Handle(ModifyItemQuantityRequest request, CancellationToken cancellationToken)
    {
        // TODO: Check if this logic is reused. for now, YAGNI

        ProductItem? productItem =
            await _productItemRepository.GetProductItemInWarehouse(request.WarehouseId, request.ProductId);

        if (productItem is null)
        {
            var newProductItem = ProductItem.Create(request.ProductId, request.WarehouseId);
            _erpContext.ProductItems.Add(newProductItem);
        }

        return Unit.Value;
    }
}