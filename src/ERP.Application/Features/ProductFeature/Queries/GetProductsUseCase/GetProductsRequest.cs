using AetherFire23.ERP.Domain.Entity;
using Mediator;

namespace ERP.Application.Features.ProductFeature.Queries.GetProductsUseCase;

public class GetProductsRequest : IRequest<IEnumerable<Product>>
{
    // TODO: Choose strategy of preloading /here ??
}