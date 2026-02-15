using Mediator;

namespace ERP.Application.Features.PurchaseOrderFeature.Commands;

public class CreatePurchaseOrderHandler : IRequestHandler<CreatePurchaseOrderRequest, Guid>
{
    public async ValueTask<Guid> Handle(CreatePurchaseOrderRequest request, CancellationToken cancellationToken)
    {
        throw new Exception("sd");
    }
}