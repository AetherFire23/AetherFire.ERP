using Mediator;

namespace ERP.Application.Features.ProductFeature.Commands.ProductCreation;

public class CreateProductCommand : IRequest
{
    public required string ProductName { get; set; }
    public required decimal BasePrice { get; set; }
}