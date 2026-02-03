using Mediator;

namespace ERP.Application.Features.UserFeature.Commands.CreateUser;

public class CreateUserHandler : IRequestHandler<CreateUserRequest>
{
    public ValueTask<Unit> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        
        return Unit.ValueTask;
    }
}