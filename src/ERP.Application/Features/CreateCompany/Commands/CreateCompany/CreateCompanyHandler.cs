using AetherFire23.ERP.Domain.Entity;
using ERP.Application.Installation;
using Mediator;

namespace ERP.Application.Features.CreateCompany.Commands.CreateCompany;

public class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest>
{
    private readonly IErpContext _erpContext;

    public CreateCompanyHandler(IErpContext erpContext)
    {
        _erpContext = erpContext;
    }

    public async ValueTask<Unit> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
    {
        Company company = Company.Create(request.CompanyName);

        User user = User.Create(request.AdminUserName, company.Id);

        _erpContext.Companies.Add(company);

        _erpContext.Users.Add(user);

        return Unit.Value;
    }
}