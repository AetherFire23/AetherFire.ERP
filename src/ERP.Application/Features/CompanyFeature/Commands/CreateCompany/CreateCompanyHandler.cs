using AetherFire23.ERP.Domain.Entity;
using ERP.Practical;
using Mediator;
using Microsoft.Extensions.Logging;

namespace ERP.Application.Features.CompanyFeature.Commands.CreateCompany;

public class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResult>
{
    private readonly ErpContext _erpContext;
    private readonly ILogger<CreateCompanyRequest> _logger;

    public CreateCompanyHandler(ErpContext erpContext, ILogger<CreateCompanyRequest> logger)
    {
        _erpContext = erpContext;
        _logger = logger;
    }

    public async ValueTask<CreateCompanyResult> Handle(CreateCompanyRequest request,
        CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting CreateCompanyHandler added to database");

        Company company = Company.Create(request.CompanyName);

        _erpContext.Companies.Add(company);
        await _erpContext.SaveChangesAsync(cancellationToken);

        User user = User.Create(request.AdminUserName, request.Password, company.Id);

        _erpContext.Users.Add(user);

        await _erpContext.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("Company added to database " + company.CompanyName);

        return new()
        {
            CompanyId = company.Id,
            UserId = user.Id,
        };
    }
}