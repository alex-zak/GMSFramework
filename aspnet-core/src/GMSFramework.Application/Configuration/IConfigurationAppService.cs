using System.Threading.Tasks;
using GMSFramework.Configuration.Dto;

namespace GMSFramework.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
