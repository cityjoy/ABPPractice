using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace MyAbpProjects.Authorization
{
    public class MyAbpProjectsAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            //Tasks
            context.CreatePermission(PermissionNames.Pages_Tasks, L("Tasks"));
            context.CreatePermission(PermissionNames.Pages_Tasks_Delete, L("DeleteTask"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, MyAbpProjectsConsts.LocalizationSourceName);
        }
    }
}
