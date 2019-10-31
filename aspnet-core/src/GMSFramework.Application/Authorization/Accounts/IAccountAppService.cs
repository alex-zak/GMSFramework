using System.Threading.Tasks;
using Abp.Application.Services;
using GMSFramework.Authorization.Accounts.Dto;

namespace GMSFramework.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
