using Mediator;

namespace ERP.Application.Features.ProductFeature.Queries.GetProductInfoUseCase;

public class GetProductDtoRequest : IRequest<ProductDto>
{
    public Guid ProductId { get; set; }
    public Guid CompanyId { get; set; }
}