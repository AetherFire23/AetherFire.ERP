using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using Mediator;
using Microsoft.Extensions.Logging;

namespace ERP.Application.Features.CreateCompany.Commands.CreateCompany;

public class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest>
{
    private readonly IErpContext _erpContext;
    private readonly ILogger _logger;

    public CreateCompanyHandler(IErpContext erpContext, ILogger logger)
    {
        _erpContext = erpContext;
        _logger = logger;
    }

    public async ValueTask<Unit> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
    {
        Company company = Company.Create(request.CompanyName);

        User user = User.Create(request.AdminUserName, company.Id);

        _erpContext.Companies.Add(company);

        _erpContext.Users.Add(user);
        
        await _erpContext.SaveChangesAsync(cancellationToken);
        
        _logger.LogInformation("Company added to database");

        return Unit.Value;
    }
}