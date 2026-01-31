using ERP.Application.Installation;
using Mediator;

namespace ERP.Application.Features.ManualAdjustmentFeature.Commands.AddProductItemQuantity;

public class ModifyItemQuantityHandler : IRequestHandler<ModifyItemQuantityRequest>
{
    private readonly IErpContext _erpContext;

    public ModifyItemQuantityHandler(IErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Unit> Handle(ModifyItemQuantityRequest request, CancellationToken cancellationToken)
    {
        // TODO: Check if this logic is reused. for now, YAGNI

        var product = _erpContext.Products.First(x => x.Id == request.ProductId);
        // If this item does not exist, create it.
        //
        // var productItem = _erpContext.ProductItems
        //     .FirstOrDefault(x => x.Id == request.ProductItemId);
        //
        // if (productItem is null)
        // {
        //     ProductItem
        // }

        return Unit.Value;
    }
}