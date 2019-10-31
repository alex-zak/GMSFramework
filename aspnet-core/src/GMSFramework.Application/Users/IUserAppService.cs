using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GMSFramework.Roles.Dto;
using GMSFramework.Users.Dto;

namespace GMSFramework.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
