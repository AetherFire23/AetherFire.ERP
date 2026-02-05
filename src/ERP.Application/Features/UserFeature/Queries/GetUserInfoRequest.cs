using Mediator;

namespace ERP.Application.Features.UserFeature.Queries;

public class GetUserInfoRequest : IRequest
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}