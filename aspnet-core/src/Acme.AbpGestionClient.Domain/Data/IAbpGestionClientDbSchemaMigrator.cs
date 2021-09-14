using System.Threading.Tasks;

namespace Acme.AbpGestionClient.Data
{
    public interface IAbpGestionClientDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
