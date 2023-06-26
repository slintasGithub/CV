using CV.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CV.Permissions;

public class CVPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CVPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CVPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CVResource>(name);
    }
}
