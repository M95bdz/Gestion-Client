using System;
using System.Collections.Generic;
using System.Text;
using Acme.AbpGestionClient.Localization;
using Volo.Abp.Application.Services;

namespace Acme.AbpGestionClient
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpGestionClientAppService : ApplicationService
    {
        protected AbpGestionClientAppService()
        {
            LocalizationResource = typeof(AbpGestionClientResource);
        }
    }
}
