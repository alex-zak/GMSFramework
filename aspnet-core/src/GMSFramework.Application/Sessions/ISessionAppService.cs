using System.Threading.Tasks;
using Abp.Application.Services;
using GMSFramework.Sessions.Dto;

namespace GMSFramework.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
