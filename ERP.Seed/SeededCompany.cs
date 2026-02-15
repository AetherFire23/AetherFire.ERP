using System.Data.SqlClient;
using ERP.Application.Features.CompanyFeature.Commands.CreateCompany;
using ERP.Application.Features.ProductFeature.Commands.ProductCreation;
using ERP.Practical;
using Mediator;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ERP.Seed;

public class SeededCompany : ISeeder
{
    private readonly IMediator _mediator;

    private readonly ErpContext _erpContext;

    public SeededCompany(IMediator mediator, ErpContext erpContext)
    {
        _mediator = mediator;
        _erpContext = erpContext;
    }

    public async Task SetupSeeding()
    {
        Console.WriteLine("sdasdsasdasd");
        await _mediator.Send(new CreateCompanyRequest
        {
            AdminUserName = "fred",
            CompanyName = "FredCo",
            Password = "BONJOUR"
        });

        var trans = _erpContext.Database.BeginTransaction();

        for (int i = 0; i < 10000; i++)
        {
            _erpContext.Database.ExecuteSqlRaw("""
                                                 INSERT INTO "Products" ("Id", "BasePrice", "ProductName")
                                                 VALUES (@p0, @p1, @p2)
                                               """,
                new NpgsqlParameter("@p0", Guid.NewGuid()),
                new NpgsqlParameter("@p1", 12),
                new NpgsqlParameter("@p2", $"SomeProduct...")
            );
        }

        trans.Commit();


        // for (int i = 0; i < 10000; i++)
        // {
        //     await _mediator.Send(new CreateProductRequest()
        //     {
        //         BasePrice = 12,
        //         ProductName = $"Hello wordl +{i}"
        //     });
        // }
    }
}