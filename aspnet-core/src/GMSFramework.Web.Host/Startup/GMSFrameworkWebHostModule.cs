using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GMSFramework.Configuration;

namespace GMSFramework.Web.Host.Startup
{
    [DependsOn(
       typeof(GMSFrameworkWebCoreModule))]
    public class GMSFrameworkWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GMSFrameworkWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GMSFrameworkWebHostModule).GetAssembly());
        }
    }
}
