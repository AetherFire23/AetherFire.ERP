using AetherFire23.ERP.Domain.Entity.Orders;
using ERP.Practical;
using Mediator;

namespace ERP.Application.Features.OrdersFeatures.Commands.CreateOrder;

public class CreateOrdersHandler : IRequestHandler<CreateOrderRequest, Guid>
{
    private readonly ErpContext _erpContext;

    public CreateOrdersHandler(ErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Guid> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        var order = new Order();

        _erpContext.Orders.Add(order);
        await _erpContext.SaveChangesAsync();

        return order.Id;
    }
}