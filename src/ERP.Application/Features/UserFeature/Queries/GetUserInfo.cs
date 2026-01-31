using Mediator;

namespace ERP.Application.Features.UserFeature.Queries;

public class GetUserInfoHandler : IRequestHandler<GetUserInfoRequest>
{
    public async ValueTask<Unit> Handle(GetUserInfoRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}