using Volo.Abp.Settings;

namespace Acme.AbpGestionClient.Settings
{
    public class AbpGestionClientSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpGestionClientSettings.MySetting1));
        }
    }
}
