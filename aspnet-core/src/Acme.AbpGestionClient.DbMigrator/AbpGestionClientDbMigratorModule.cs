using Acme.AbpGestionClient.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.AbpGestionClient.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpGestionClientEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpGestionClientApplicationContractsModule)
        )]
    public class AbpGestionClientDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
