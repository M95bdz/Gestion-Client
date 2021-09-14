using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.AbpGestionClient.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpGestionClientEntityFrameworkCoreModule)
        )]
    public class AbpGestionClientEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpGestionClientMigrationsDbContext>();
        }
    }
}
