using ERP.Application.Installation;
using Mediator;

namespace ERP.Application.Features.Warehouse.Commands;

public class CreateWarehouse : IRequestHandler<CreateWarehouseRequest>
{
    private readonly IErpContext _erpContext;

    public CreateWarehouse(IErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Unit> Handle(CreateWarehouseRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}