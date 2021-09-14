using Volo.Abp.Modularity;

namespace Acme.AbpGestionClient
{
    [DependsOn(
        typeof(AbpGestionClientApplicationModule),
        typeof(AbpGestionClientDomainTestModule)
        )]
    public class AbpGestionClientApplicationTestModule : AbpModule
    {

    }
}