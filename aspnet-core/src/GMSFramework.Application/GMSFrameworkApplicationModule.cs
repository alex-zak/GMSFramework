using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GMSFramework.Authorization;

namespace GMSFramework
{
    [DependsOn(
        typeof(GMSFrameworkCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GMSFrameworkApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GMSFrameworkAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GMSFrameworkApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
