using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using Mediator;

namespace ERP.Application.Features.ProductFeature.Commands.ProductCreation;

public class CreateProduct : IRequestHandler<CreateProductCommand>
{
    private readonly IErpContext _erpContext;

    public CreateProduct(IErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            ProductName = request.ProductName,
            BasePrice = request.BasePrice
        };

        _erpContext.Products.Add(product);

        await _erpContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}