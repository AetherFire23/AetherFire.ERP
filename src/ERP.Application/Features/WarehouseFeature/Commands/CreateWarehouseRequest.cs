using Mediator;

namespace ERP.Application.Features.WarehouseFeature.Commands;

public class CreateWarehouseRequest : IRequest<Guid>
{
    public required Guid CompanyId { get; set; }
    public required string WarehouseName { get; set; }
}