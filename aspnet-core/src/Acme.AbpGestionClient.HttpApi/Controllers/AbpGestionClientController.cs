using Acme.AbpGestionClient.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.AbpGestionClient.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpGestionClientController : AbpController
    {
        protected AbpGestionClientController()
        {
            LocalizationResource = typeof(AbpGestionClientResource);
        }
    }
}