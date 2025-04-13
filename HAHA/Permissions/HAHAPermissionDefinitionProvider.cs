using HAHA.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace HAHA.Permissions;

public class HAHAPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HAHAPermissions.GroupName);

        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HAHAPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HAHAResource>(name);
    }
}
