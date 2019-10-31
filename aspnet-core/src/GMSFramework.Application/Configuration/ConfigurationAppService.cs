using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GMSFramework.Configuration.Dto;

namespace GMSFramework.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GMSFrameworkAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
