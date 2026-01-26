using Mediator;

namespace ERP.Application.Features.Warehouse.Commands;

public class CreateWarehouseRequest : IRequest
{
    public required string WarehouseName { get; set; }
}