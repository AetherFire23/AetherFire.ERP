using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using ERP.Application.Features.ProductFeature.Commands.ProductCreation;
using ERP.Application.Features.WarehouseFeature.Commands;
using JetBrains.Annotations;
using Xunit.Abstractions;

namespace ERP.Integration.Features.WarehouseFeature.Commands;

[TestSubject(typeof(CreateWarehouse))]
public class CreateWarehouseTest : ErpIntegrationTestBase
{
    public CreateWarehouseTest(ITestOutputHelper output) : base(output)
    {
        
    }

    [Fact]
    public async Task GivenAManager_CreatesAWarehouse_WarehouseExists()
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

        // await Mediator.Send(new CreateWarehouseRequest
        // {
        //     CompanyId =
        //         WarehouseName = "Quebec",
        // });
    }
}