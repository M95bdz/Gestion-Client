using Acme.AbpGestionClient.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.AbpGestionClient.Permissions
{
    public class AbpGestionClientPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpGestionClientPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpGestionClientPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpGestionClientResource>(name);
        }
    }
}
