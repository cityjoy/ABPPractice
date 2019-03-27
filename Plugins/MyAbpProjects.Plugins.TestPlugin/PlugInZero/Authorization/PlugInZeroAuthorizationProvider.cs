using Abp.Authorization;
using Abp.Localization;

namespace MyAbpProjects.PlugIns.PlugInZero.Authorization
{
    public class PlugInZeroAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //父节点
            var parentPermission = context.GetPermissionOrNull(PlugInZeroConsts.PermissionNames.PlugIns);
            if (parentPermission == null)
            {
                parentPermission = context.CreatePermission(
                    PlugInZeroConsts.PermissionNames.PlugIns
                    , new FixedLocalizableString("插件权限")//这里省略插件中的本地化机制
                    , multiTenancySides: Abp.MultiTenancy.MultiTenancySides.Host);
            }
            //权限
            var menuPermisson = parentPermission.CreateChildPermission(
                PlugInZeroConsts.PermissionNames.PlugInZero
                , new FixedLocalizableString("PlugInZero管理")
                , multiTenancySides: Abp.MultiTenancy.MultiTenancySides.Host);
        }
    }
}
