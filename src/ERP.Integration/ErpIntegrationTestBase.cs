using System.Reflection;
using AetherFire23.Commons.Testing;
using AetherFire23.ERP.Domain;
using ERP.Infrastructure.Contexts;

namespace ERP.Integration;

public class ErpIntegrationTestBase : PostgresTestContainer
{
    protected override IEnumerable<Assembly> ProvideInstallerAssemblies()
    {
        return
        [
            typeof(DomainInstaller).Assembly,
            typeof(ErpContext).Assembly,
        ];
    }
}