using System.Reflection;
using AetherFire23.Commons.Testing;
using AetherFire23.ERP.Domain;
using ERP.Application.Installation;
using ERP.Infrastructure.Contexts;
using Mediator;

namespace ERP.Integration;

public class ErpIntegrationTestBase : PostgresTestContainer
{
    protected IMediator Mediator;

    public ErpIntegrationTestBase()
    {
        Mediator = GetService<IMediator>();
    }

    protected override IEnumerable<Assembly> ProvideInstallerAssemblies()
    {
        return
        [
            typeof(DomainInstaller).Assembly,
            typeof(ErpContext).Assembly,
            typeof(ApplicationInstaller).Assembly
        ];
    }
}