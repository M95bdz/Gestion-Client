using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.AbpGestionClient.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.AbpGestionClient.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpGestionClientDbSchemaMigrator
        : IAbpGestionClientDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpGestionClientDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpGestionClientMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpGestionClientMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}