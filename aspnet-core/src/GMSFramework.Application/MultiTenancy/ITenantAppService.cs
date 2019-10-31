using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GMSFramework.MultiTenancy.Dto;

namespace GMSFramework.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

