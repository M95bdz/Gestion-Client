using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.AbpGestionClient.Data
{
    /* This is used if database provider does't define
     * IAbpGestionClientDbSchemaMigrator implementation.
     */
    public class NullAbpGestionClientDbSchemaMigrator : IAbpGestionClientDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}