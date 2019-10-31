using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GMSFramework.Configuration;
using GMSFramework.EntityFrameworkCore;
using GMSFramework.Migrator.DependencyInjection;

namespace GMSFramework.Migrator
{
    [DependsOn(typeof(GMSFrameworkEntityFrameworkModule))]
    public class GMSFrameworkMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GMSFrameworkMigratorModule(GMSFrameworkEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(GMSFrameworkMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                GMSFrameworkConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GMSFrameworkMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
