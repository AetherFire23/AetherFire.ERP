using Mediator;

namespace ERP.Application.Features.Warehouse.Commands;

public class CreateWarehouse : IRequestHandler<CreateWarehouseRequest>
{
    public async ValueTask<Unit> Handle(CreateWarehouseRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}