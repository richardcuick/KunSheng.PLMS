using Kunsheng.PLMS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kunsheng.PLMS.Permissions;

public class PLMSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PLMSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PLMSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PLMSResource>(name);
    }
}
