using Mediator;

namespace ERP.Application.Features.CreateCompany.Commands.CreateCompany;

public class CreateCompanyRequest : IRequest
{
    public required string CompanyName { get; set; }

    public required string AdminUserName { get; set; }
    
}