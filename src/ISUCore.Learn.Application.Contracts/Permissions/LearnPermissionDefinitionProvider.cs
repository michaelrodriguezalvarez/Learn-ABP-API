using ISUCore.Learn.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ISUCore.Learn.Permissions;

public class LearnPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LearnPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LearnPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LearnResource>(name);
    }
}
