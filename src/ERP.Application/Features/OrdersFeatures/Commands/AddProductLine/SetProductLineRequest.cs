using Mediator;

namespace ERP.Application.Features.OrdersFeatures.Commands.AddProductLine;

public class SetProductLineRequest : IRequest
{
    public required Guid OrderId { get; set; }
    public required Guid Product { get; set; }
    public required int Quantity { get; set; }
}