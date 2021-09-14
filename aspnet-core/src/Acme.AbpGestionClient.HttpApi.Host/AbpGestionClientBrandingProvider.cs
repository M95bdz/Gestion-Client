using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.AbpGestionClient
{
    [Dependency(ReplaceServices = true)]
    public class AbpGestionClientBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpGestionClient";
    }
}
