using Mediator;

namespace ERP.Application.Features.CompanyFeature.Commands.CreateCompany;

public class CreateCompanyRequest : IRequest<CreateCompanyResult>
{
    public required string CompanyName { get; set; }

    public required string AdminUserName { get; set; }

    public required string Password { get; set; }
}