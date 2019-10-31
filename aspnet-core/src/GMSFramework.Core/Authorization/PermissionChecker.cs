using Abp.Authorization;
using GMSFramework.Authorization.Roles;
using GMSFramework.Authorization.Users;

namespace GMSFramework.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
