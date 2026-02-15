using AetherFire23.ERP.Domain.Entity;
using AetherFire23.ERP.Domain.Entity.Orders;
using ERP.Practical;
using Mediator;
using Microsoft.EntityFrameworkCore;

namespace ERP.Application.Features.OrdersFeatures.Commands.AddProductLine;

public class SetProductLineHandler : IRequestHandler<SetProductLineRequest>
{
    private readonly ErpContext _erpContext;

    public SetProductLineHandler(ErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Unit> Handle(SetProductLineRequest request, CancellationToken cancellationToken)
    {
        // Getting the relevant entities 
        Order? order = await _erpContext.Orders
            .Include(x => x.OrderProductLines)
                .ThenInclude(x => x.Product)
            .FirstAsync(x => x.Id == request.OrderId, cancellationToken);

        // Order may already have a product line 
        Product product = await _erpContext.Products.FirstAsync(x => x.Id == request.Product, cancellationToken);

        if (order.HasLine(product))
        {
            order.GetLine(product).QuantityOrdered = request.Quantity;
        }
        else
        {
            _erpContext.Add(order.AddProductLine(product, request.Quantity));
        }

        await _erpContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
