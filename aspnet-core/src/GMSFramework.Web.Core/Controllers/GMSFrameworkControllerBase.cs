using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GMSFramework.Controllers
{
    public abstract class GMSFrameworkControllerBase: AbpController
    {
        protected GMSFrameworkControllerBase()
        {
            LocalizationSourceName = GMSFrameworkConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
