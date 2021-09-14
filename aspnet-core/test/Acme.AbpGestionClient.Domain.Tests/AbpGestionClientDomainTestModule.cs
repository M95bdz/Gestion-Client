using Acme.AbpGestionClient.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.AbpGestionClient
{
    [DependsOn(
        typeof(AbpGestionClientEntityFrameworkCoreTestModule)
        )]
    public class AbpGestionClientDomainTestModule : AbpModule
    {

    }
}