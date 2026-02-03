using Mediator;

namespace ERP.Application.Features.UserFeature.Commands.CreateUser;

public class CreateUserRequest : IRequest
{
    public string Username { get; init; }
}