using Abp.Authorization;
using MyAbpProjects.Authorization.Roles;
using MyAbpProjects.Authorization.Users;

namespace MyAbpProjects.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
