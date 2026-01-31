using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using Mediator;

namespace ERP.Application.Features.WarehouseFeature.Commands;

/// <summary>
/// An admin / buyer / owner can create a new warehouse. 
/// </summary>
public class CreateWarehouse : IRequestHandler<CreateWarehouseRequest>
{
    private readonly IErpContext _erpContext;

    public CreateWarehouse(IErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Unit> Handle(CreateWarehouseRequest request, CancellationToken cancellationToken)
    {
        var warehouse = new Warehouse
        {
            WarehouseName = request.WarehouseName,
            CompanyId = request.CompanyId,
        };

        _erpContext.Warehouses.Add(warehouse);

        await _erpContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}