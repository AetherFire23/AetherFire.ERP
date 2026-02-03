using ERP.Application.Features.CreateCompany.Commands.CreateCompany;
using Mediator;

namespace ERP.Seed;

public class SeededCompany : ISeeder
{
    private readonly IMediator _mediator;

    public SeededCompany(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task SetupSeeding()
    {
        await _mediator.Send(new CreateCompanyRequest
        {
            AdminUserName = "fred",
            CompanyName = "FredCo"
        });
    }
}