using Acme.AbpGestionClient.GClients;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.AbpGestionClient.EntityFrameworkCore
{
    public static class AbpGestionClientDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpGestionClient(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<GClient>(b =>
            {
                b.ToTable(AbpGestionClientConsts.DbTablePrefix + "GClients",
                          AbpGestionClientConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.NomComplet).IsRequired().HasMaxLength(128);
            });
        }
    }
}