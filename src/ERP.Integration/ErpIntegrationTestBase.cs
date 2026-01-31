using System.Reflection;
using AetherFire23.Commons.Testing;
using AetherFire23.ERP.Domain;
using ERP.Application.Installation;
using ERP.Infrastructure.Contexts;
using Mediator;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Abstractions;

namespace ERP.Integration;

public class ErpIntegrationTestBase : PostgresTestContainer
{
    protected IMediator Mediator;
    protected ITestOutputHelper Output;
    protected ErpContext Context;

    public ErpIntegrationTestBase(ITestOutputHelper output)
    {
        Output = output;
        Mediator = GetService<IMediator>();
        Context = GetService<ErpContext>();
    }

    protected override IEnumerable<Assembly> ProvideInstallerAssemblies()
    {
        return
        [
            typeof(DomainInstaller).Assembly,
            typeof(ErpContext).Assembly,
            typeof(ApplicationInstaller).Assembly,
            typeof(ErpIntegrationTestBase).Assembly,
        ];
    }
}