using AetherFire23.ERP.Domain.Entity;
using ERP.Practical;
using Mediator;
using Microsoft.Extensions.Logging;

namespace ERP.Application.Features.ProductFeature.Commands.ProductCreation;

public class CreateProduct : IRequestHandler<CreateProductCommand>
{
    private readonly ErpContext _erpContext;
    private readonly ILogger<CreateProduct> _logger;

    public CreateProduct(ErpContext erpContext, ILogger<CreateProduct> logger)
    {
        _erpContext = erpContext;
        _logger = logger;
    }

    public async ValueTask<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {

        Product product = new Product
        {
            ProductName = request.ProductName,
            BasePrice = request.BasePrice
        };
        
        _erpContext.Products.Add(product);

        await _erpContext.SaveChangesAsync(cancellationToken);
        _logger.LogInformation($"Added product {request.ProductName} with price {request.BasePrice}");
        
        return Unit.Value;
    }
}