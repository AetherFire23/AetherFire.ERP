using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using ERP.Application.Features.ProductFeature.Commands.ProductCreation;
using JetBrains.Annotations;
using Xunit.Abstractions;

namespace ERP.Integration.Features.ProductFeature.Commands.ProductCreation;

[TestSubject(typeof(CreateProduct))]
public class CreateProductTest : ErpIntegrationTestBase
{
    public CreateProductTest(ITestOutputHelper output) : base(output)
    {
    }

    [Fact]
    public async Task GivenAManager_CreatesAProduct_ProductExists()
    {
        await Mediator.Send(new CreateCompanyRequest
        {
            CompanyName = "FredCo",
            AdminUserName = "admin"
        });

        await Mediator.Send(new CreateProductCommand
        {
            BasePrice = 14,
            ProductName = "TN760 REU",
        });
        
        Assert.NotEmpty(this.Context.Products.ToList());
    }
}